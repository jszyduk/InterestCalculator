import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LoanResult } from 'src/app/entities/loanResult';
import { Loan } from 'src/app/entities/loan';
import { PaybackStrategy } from 'src/app/utils/PaybackStrategy';

@Component({
  selector: 'app-car-loan',
  templateUrl: './car-loan.component.html',
  styleUrls: ['./car-loan.component.css']
})
export class CarLoanComponent {

  public loanCost: LoanResult;
  public loan = new Loan();

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) {

  }

  receiveLoanData($event) {
    this.loan = $event;

    this.callApi();
  }

  callApi() {
    this.http.get<LoanResult>(`${this.baseUrl}carloan/${this.loan.amount}/${this.loan.years}/${PaybackStrategy.Steady}`).subscribe(result => {
      this.loanCost = result;
    },
      error => console.error(error));
  }

}
