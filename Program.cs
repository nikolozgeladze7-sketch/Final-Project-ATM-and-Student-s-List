using Final_Project;

BankingSystem bankingSystem = new BankingSystem();
KeyListener keyListener = new KeyListener();
UserAccountStorage storage = new UserAccountStorage("balance.txt");

/// მოვლენების მეთოდებთან დაკავშირება

keyListener.OnBalanceCheck += bankingSystem.ShowBalance;
keyListener.OnWithdraw += amount =>
{
    bankingSystem.WithdrawMoney(amount);
    storage.SaveBalance(bankingSystem.GetBalance());
};
keyListener.OnAddMoney += amount =>
{
    bankingSystem.AddMoney(amount);
    storage.SaveBalance(bankingSystem.GetBalance());
};


/// მომხმარებლის შეყვანის მოსმენა და პროცესის დაწყება
keyListener.StartListening();










//StudentManager studentManager = new StudentManager();
//Student student = new Student();

//studentManager.OnAddStudent += student.AddStudent;
//studentManager.OnRemoveStudent += student.RemoveStudent;
//studentManager.OnShowStudent += student.ShowAll;
//studentManager.OnSearchStudent += student.Search;

//studentManager.StartStudentList();
