import { Component, OnInit } from "@angular/core";
import { NewsletterDataService } from "@services/newsletter-data.service";
import { ActivatedRoute, Router } from "@angular/router";

@Component({
  selector: "app-newsletter-confirmation",
  templateUrl: "./newsletter-confirmation.component.html",
  styleUrls: ["./newsletter-confirmation.component.scss"]
})
/** newsletter-confirmation component*/
export class NewsletterConfirmationComponent implements OnInit {

  slug: string;
  description: string;
  title: string;
  email: string;
  code: string;
  verificationResult: string;

  /** newsletter-confirmation ctor */
  constructor(private newsletterDataService: NewsletterDataService,
    private route: ActivatedRoute,
    private router: Router) {
    this.route.paramMap.subscribe(params => this.slug = params.get("slug"));
    this.route.queryParamMap.subscribe(params => this.code = params.get("code"));
  }

  ngOnInit(): void {
    if (this.slug != null) {
      // validate the code.
      this.newsletterDataService.verifyCode(this.slug, this.code)
        .subscribe((verificationResult) => {
          // alert(verificationResult);
          this.verificationResult = verificationResult.toString();
        });
    }
  }
}
