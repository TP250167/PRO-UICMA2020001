import { Component, OnInit, AfterViewInit } from '@angular/core';
import { AngularEditorConfig } from '@kolkov/angular-editor';


import { AppService } from '@services/app.service'

@Component({
  selector: 'app-form-template-management',
  templateUrl: './form-template-management.component.html',
  styleUrls: ['./form-template-management.component.scss']
})
export class FormTemplateManagementComponent implements OnInit {

  constructor(
    public aps: AppService,
  ) { }


  public editorConfig: AngularEditorConfig = {
    editable: true,
    spellcheck: true,
    height: 'auto',
    minHeight: '0',
    maxHeight: 'auto',
    width: 'auto',
    minWidth: '0',
    translate: 'yes',
    enableToolbar: true,
    showToolbar: true,
    placeholder: 'Enter text here...',
    defaultParagraphSeparator: '',
    defaultFontName: '',
    defaultFontSize: '',
    fonts: [
      { class: 'arial', name: 'Arial' },
      { class: 'times-new-roman', name: 'Times New Roman' },
      { class: 'calibri', name: 'Calibri' },
      { class: 'comic-sans-ms', name: 'Comic Sans MS' }
    ],
    customClasses: [
      {
        name: 'quote',
        class: 'quote',
      },
      {
        name: 'redText',
        class: 'redText'
      },
      {
        name: 'titleText',
        class: 'titleText',
        tag: 'h1',
      },
    ],
    sanitize: true,
    toolbarPosition: 'top',
    toolbarHiddenButtons: [
      // ['bold', 'italic'],
      // ['fontSize']
    ]
  };

  fixedHeaderFooterEditor() {

    let headerContent = `
        <div class='cc-ftm-header' style="border-left: 1px solid #e8e8e8; border-right: 1px solid #e8e8e8; padding: 0 15px;">
          <div>
            <img />
            <div>
              <h3 style="font-size: 22px; font-family: 'Arial'; font-weight: bold; font-style: oblique; margin: 0;color: #2d2d2d;">Los Angeles Unified School District</h3>
              <h4 style="font-size: 16px; font-family: 'Arial'; font-weight: 600; margin: 0;color: #2d2d2d;">OFFICE OF BUSINESS SUPPORT</h4>
              <p style="margin: 0;font-family: 'Arial';">333 A.Beaudry Avenue, 18<sup>th</sup>Floor</p>
              <p style="margin: 0;font-family: 'Arial';">Los Angeles, CA 90017-5141</p>
              <p style="margin: 0;font-family: 'Arial';">TELEPHONE(213)241-4133;<a href="www.lausd.net">www.lausd.net</a></p>
            </div>
          </div>	
        </div>
     `
    let footerContent = `
    <div class="cc-ftm-footer" style="border-left: 1px solid #e8e8e8; border-right: 1px solid #e8e8e8; border-bottom: 1px solid #e8e8e8; padding: 0 15px;">
      <div>
      <p>By signing below, I certify that i am an authorized representative and the imformation provided in reponse to this notice is
      true and correct. I understand that any false statement, false representation, or failure to report a material fact may result in
      employer penalties and charges.</p>
      </div>
      <div> 
        <div>
          <span style="display:inline-block;margin-bottom:20px;margin-right:10px">Print Name: ___________________________ </span>
          <span style="display:inline-block;margin-bottom:20px;margin-right:10px">Phone Number: ______ ______ ______</span>
          <span style="display:inline-block;margin-bottom:20px;margin-right:10px">Signature: ___________________________ </span>
        </div>
        <div>
          <span style="display:inline-block;margin-bottom:20px;margin-right:10px">Title: ___________________________ </span>
          <span style="display:inline-block;margin-bottom:20px;margin-right:10px">Date: ___________________________ </span>
        </div>
      </div>
    </div>
    `
    let ele = document.querySelector('.angular-editor-textarea');
    ele.insertAdjacentHTML('beforebegin', headerContent)
    ele.insertAdjacentHTML('afterend', footerContent)

  }

  ngOnInit() {
  }

  ngAfterViewInit() {
    this.fixedHeaderFooterEditor()
  }

}
