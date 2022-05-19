// See https://aka.ms/new-console-template for more information

using encapsulationGradeActivity.Models;

Student romeo = new("romeo",'B',2);
romeo.Upgrade();

Student nick = new("nick", 'E', 3);
nick.Downgrade();

Student rosy = new("rosy", 'D', 4);
rosy.Upgrade();
