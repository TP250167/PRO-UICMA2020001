import { Component, OnInit } from '@angular/core';



@Component({
  selector: 'app-pdf-viewer',
  templateUrl: './pdf-viewer.component.html',
  styleUrls: ['./pdf-viewer.component.scss']
})
export class PdfViewerComponent implements OnInit {

  public docSelection: number = 0;
  public sourceSrc: string;
  public sourceType: string;

  public docList: any = [
    {
      "id": 0,
      "docName": "form pdf",
      "docType": "pdf",
      "docUrl": "http://localhost:4200/assets/pdf/flyer.pdf",
    },
    {
      "id": 1,
      "docName": "form img",
      "docType": "img",
      "docUrl": "http://localhost:4200/assets/pdf/thumb-1920-926492.jpg",
    },
    {
      "id": 2,
      "docName": "form pdf",
      "docType": "pdf",
      "docUrl": "http://localhost:4200/assets/pdf/gre_research_validity_data.pdf",
    },
    {
      "id": 3,
      "docName": "form pdf",
      "docType": "pdf",
      "docUrl": "http://localhost:4200/assets/pdf/pdf-test.pdf",
    },
    {
      "id": 4,
      "docName": "form pdf",
      "docType": "pdf",
      "docUrl": "http://localhost:4200/assets/pdf/sample.pdf",
    }
  ]

  public pageIndex: number = 1;
  public totalPage: number;
  public zoomMax: number = 5;
  public zoom: number = 1;




  constructor() { }

  pdfviewPreviousPage() {
    if (this.pageIndex > 1) {
      this.pageIndex = this.pageIndex - 1;
    }
  }

  pdfviewNextPage() {
    if (this.pageIndex < this.totalPage) {
      this.pageIndex = this.pageIndex + 1;
    }
  }

  zoomIn() {
    if (this.zoomMax > this.zoom) {
      this.zoom = parseFloat((this.zoom + 0.1).toPrecision(2));
    }
  }

  zoomOut() {
    if (this.zoom > 1) {
      this.zoom = parseFloat((this.zoom - 0.1).toPrecision(2));
    }
  }


  afterLoadComplete(ev) {
    this.totalPage = ev.numPages
  }

  setDocument(val) {

    this.pageIndex = 1;
    this.totalPage = 1;

    this.sourceSrc = this.docList[val].docUrl;
    this.sourceType = this.docList[val].docType;
  }

  ngOnInit() {
    this.setDocument(this.docSelection)
  }

}
