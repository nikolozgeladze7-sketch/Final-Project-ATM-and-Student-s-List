BankingSystem bankingSystem = new BankingSystem();
KeyListener keyListener = new KeyListener();

keyListener.OnBalanceCheck += bankingSystem.ShowBalance;
keyListener.OnWithdraw += bankingSystem.WithdrawMoney;
keyListener.OnAddMoney += bankingSystem.AddMoney;

keyListener.StartListening();










//StudentManager studentManager = new StudentManager();
//Student student = new Student();

//studentManager.OnAddStudent += student.AddStudent;
//studentManager.OnRemoveStudent += student.RemoveStudent;
//studentManager.OnShowStudent += student.ShowAll;
//studentManager.OnSearchStudent += student.Search;

//studentManager.StartStudentList();
