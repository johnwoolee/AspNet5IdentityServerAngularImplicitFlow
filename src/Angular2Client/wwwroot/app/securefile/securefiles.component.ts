import { Component, OnInit } from 'angular2/core';
import { CORE_DIRECTIVES } from 'angular2/common';
import { SecureFileService } from './SecureFileService';
import { SecurityService } from '../services/SecurityService';
import { Observable }       from 'rxjs/Observable';
import { Router } from 'angular2/router';

@Component({
    selector: 'securefiles',
    templateUrl: 'app/securefile/securefiles.component.html',
    directives: [CORE_DIRECTIVES],
    providers: [SecureFileService]
})

export class SecureFilesComponent implements OnInit {

    public message: string;
    public Files: string[];
   
    constructor(private _secureFileService: SecureFileService, public securityService: SecurityService, private _router: Router) {
        this.message = "Secure Files download";
    }

    ngOnInit() {
      this.getData();
    }

    public DownloadFileById(id: any) {
        this._secureFileService.DownloadFile(id);
    }

    private getData() {
        this._secureFileService.GetListOfFiles()
            .subscribe(data => this.Files = data,
            error => this.securityService.HandleError(error),
            () => console.log('Get all completed'));
    }
}
