import { Component, OnInit, ViewChild } from "@angular/core";
import { FeatureFlagService } from "@services/feature-flag.service";
import { ActivatedRoute } from "@angular/router";
import { of, Observable } from "rxjs";
import { AccountProfileComponent } from "@components/account-profile/account-profile.component";
import { ApplicationLicenseeChangesComponent } from
  "@components/applications/application-licensee-changes/application-licensee-changes.component";
import { ApplicationComponent } from "@components/applications/application/application.component";
import { DynamicApplicationComponent } from
  "@components/applications/dynamic-application/dynamic-application.component";
import { ApplicationDataService } from "@services/application-data.service";
import { Application } from "@models/application.model";
import { faCheck } from "@fortawesome/free-solid-svg-icons";



@Component({
  selector: "app-multi-stage-application-flow",
  templateUrl: "./multi-stage-application-flow.component.html",
  styleUrls: ["./multi-stage-application-flow.component.scss"]
})
export class MultiStageApplicationFlowComponent implements OnInit {
  faCheck = faCheck;
  securityScreeningEnabled: boolean;
  applicationId: string;
  isFree: boolean = false;
  hasLGApproval: boolean = false;

  @ViewChild("accountProfile")
  accountProfileComponent: AccountProfileComponent;
  @ViewChild("orgStructure")
  licenseeChangesComponent: ApplicationLicenseeChangesComponent;
  @ViewChild("mainApplication")
  applicationComponent: ApplicationComponent;
  @ViewChild("dynamicApplication")
  dynamicApplicationComponent: DynamicApplicationComponent;
  stepType: "post-lg-decision";
  application: Application;
  allSteps = ["account-profile", "licensee-changes", "application", "security-screening", "payment"];
  stepsForApplication = [];

  constructor(public featureFlagService: FeatureFlagService,
    private route: ActivatedRoute,
    public applicationDataService: ApplicationDataService,
  ) {

    featureFlagService.featureOn("SecurityScreening")
      .subscribe(featureOn => this.securityScreeningEnabled = featureOn);

    this.route.paramMap.subscribe(params => {
      this.applicationId = params.get("applicationId");
      if (params.get("stepType") === "post-lg-decision") {
        this.stepType = "post-lg-decision";
      }
    });

  }

  ngOnInit() {
    this.applicationDataService.getApplicationById(this.applicationId)
      .subscribe((data: Application) => {
          this.application = data;
          if (data.applicantType === "IndigenousNation") {
            (data as any).applyAsIndigenousNation = true;
          }
          this.isFree = data.applicationType.isFree;
          this.stepsForApplication = this.determineSteps();
        },
        () => {
          console.log("Error occured");
        }
      );
  }

  // determine which steps to show or hide
  determineSteps(): string[] {
    const steps = [];
    this.allSteps.forEach(step => {
      if (
        (step === "account-profile" && this.stepType !== "post-lg-decision") ||
          (step === "licensee-changes" &&
            this.stepType !== "post-lg-decision" &&
            this.securityScreeningEnabled &&
            this.application &&
            this.application.applicationType.requiresSecurityScreening) ||
          (step === "application") ||
          (step === "security-screening" &&
            this.securityScreeningEnabled &&
            this.application &&
            this.application.applicationType.requiresSecurityScreening) ||
          (step === "payment" && this.applicationId && !this.isFree)
      ) {
        steps.push(step);
      }
    });
    return steps;
  }

  canDeactivate(): Observable<boolean> {
    let result: Observable<boolean> = of(true);
    if (this.accountProfileComponent) {
      result = this.accountProfileComponent.canDeactivate();
    }
    if (this.licenseeChangesComponent) {
      result = this.licenseeChangesComponent.canDeactivate();
    }
    if (this.applicationComponent) {
      result = this.applicationComponent.canDeactivate();
    }
    if (this.dynamicApplicationComponent) {
      result = this.dynamicApplicationComponent.canDeactivate();
    }
    return result;
  }


  selectionChange(event) {

  }

}
