import { Component, OnInit, AfterViewInit } from '@angular/core';
import { AngularEditorConfig } from '@kolkov/angular-editor';


import { AppService } from 'app/@services/app.service'

declare var $: any;


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
        <div class='cc-ftm-header'>
          <div class="cc-ftm-img-wrapper">
            <img src="http://localhost:4200/assets/img/Capture.PNG" />
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
    <div class="cc-ftm-footer">
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

  printPdf() {

    $(".angular-editor-wrapper").printThis({
      debug: false,               // show the iframe for debugging
      importCSS: true,            // import parent page css
      importStyle: true,         // import style tags
      printContainer: false,       // print outer container/$.selector
      loadCSS: "",                // path to additional css file - use an array [] for multiple
      pageTitle: "DE1101 response",  // add title to print page
      removeInline: false,        // remove inline styles from print elements
      removeInlineSelector: "*",  // custom selectors to filter inline styles. removeInline must be true
      printDelay: 333,            // variable print delay
      header: null,               // prefix to html
      footer: null,               // postfix to html
      base: false,                // preserve the BASE tag or accept a string for the URL
      formValues: true,           // preserve input/form values
      canvas: false,              // copy canvas content
      doctypeString: '...',       // enter a different doctype for older markup
      removeScripts: false,       // remove script tags from print content
      copyTagClasses: true,      // copy classes from the html & body tag
      beforePrintEvent: null,     // function for printEvent in iframe
      beforePrint: null,          // function called before iframe is filled
      afterPrint: null            // function called before iframe is removed
    });


  }

  ngOnInit() {
  }

  ngAfterViewInit() {
    this.fixedHeaderFooterEditor()
  }

}
