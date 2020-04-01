export class RaWeeklyBatchModel {
    id                           : number;
    batchName                    : string;
    batchDescription             : string;
    frequency                    : string;
    isRecuring                   : boolean;
    occurrance                   : string;
    status                       : string;
    time                         : string;
    createdBy                    : string;
    modifiedBy                   : string;
    createdOn                    : string;
    modifiedOn                   : string;
    nextOccurrance               : string;
    templateID                   : number;
    isAnnual                     : boolean;
    isCustom                     : boolean;
    uploadExcel                  : string;
    filetype                     : string;
    rAbatchRecipientRule         : string;
    rAbatchSchedule              : string;
    rAbatchTemplate              : string;
    rAbatchRecipient             : string;
    rAbatchRecRule               : string;
    raSchedule                   : string;
}
