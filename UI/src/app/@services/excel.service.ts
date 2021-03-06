import { Injectable } from '@angular/core';

import * as json2csv from 'json2csv'; // convert json file to csv
import { saveAs } from 'file-saver';

@Injectable({
  providedIn: 'root'
})
export class ExcelService {

  public Json2csvParser = json2csv.Parser;

  constructor() { }

  public convertToCSV(objArray: any, fields?) {
    let json2csvParser = new this.Json2csvParser({ opts: fields });
    let csv = json2csvParser.parse(objArray);
    console.log(csv);
    return csv;
  }

  public downloadFile(data: any, filename: string) {
    let csvData = this.convertToCSV(data);
    let file = new Blob([csvData], { type: 'text/csv;charset=utf-8' });
    saveAs(file, filename);
  }


}
