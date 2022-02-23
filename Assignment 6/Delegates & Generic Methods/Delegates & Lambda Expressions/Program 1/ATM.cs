class ATM {
    public int account_no;
    public String account_holder_name;
    public double avaliable_balance;

    public ATM(int acc_no, String acc_name, double ava_bal) {
        this.account_no = acc_no;
        this.account_holder_name = acc_name;
        this.avaliable_balance = ava_bal;
    }
}