export interface LoanResult {

  months: Array<LoanCostItem>;
  totalInterestAmount: number;
  totalPaybackAmount: number;

}

export interface LoanCostItem {
  month: number;
  amout: number;
  interest: number;
  total: number;
}
