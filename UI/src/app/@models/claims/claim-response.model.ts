export class ClaimResponseModel {
    id: number;
    claimId: number;
    state: string;
    city: string;
    zipcode: string;
    address: string;
    lausdMailDate: string;
    bybClaimDate: string;
    effectiveDateOfClaim: string;
    dueDate: string;
    claimantName: string;
    socialSecurityNumber: string;
    lausdResponse: string;
    representativeName: string;
    phoneNumber: string;
    signature: string;
    title: string;
    date: string;
    issuesList: number;
    createdBy: string;
    createdOn: string;
    modifiedBy: string;
    modifiedOn: string;
    raLetter: boolean;
    protestPage: boolean;
    eeContract: boolean;
    timeWageReport: boolean;
    statementOfCharges: boolean;
    offerLetter: boolean;
    subCalender: boolean;
    warningLetters: boolean;
    other: boolean;
    formCode: string;
}
