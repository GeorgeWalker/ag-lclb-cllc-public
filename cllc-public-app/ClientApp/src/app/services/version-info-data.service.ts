import { DataService } from "./data.service";
import { Injectable } from "@angular/core";
import { HttpHeaders, HttpClient } from "@angular/common/http";

import { VersionInfo } from "@models/version-info.model";
import { catchError } from "rxjs/operators";
import { Observable } from "rxjs";

@Injectable()
export class VersionInfoDataService extends DataService {

  apiPath = "api/ApplicationVersionInfo";
  headers = new HttpHeaders({
    'Content-Type': "application/json"
  });

  constructor(private http: HttpClient) { super(); }

  getVersionInfo(): Observable<VersionInfo> {
    return this.http.get<VersionInfo>(this.apiPath, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }
}
