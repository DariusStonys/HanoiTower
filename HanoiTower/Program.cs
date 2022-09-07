using HanoiTower.Model;
using HanoiTower.HelperMethods;

var disk1 = new Disk(1);
var disk2 = new Disk(2);
var disk3 = new Disk(3);
var disk4 = new Disk(4);

var row1 = new Row(disk1);
var row2 = new Row(disk2);
var row3 = new Row(disk3);
var row4 = new Row(disk4);

var peg1 = new Peg(new Row(), new Row(), row1, row2);
var peg2 = new Peg(new Row(), new Row(), row3, row4);
var peg3 = new Peg();

var tower = new Tower(peg1, peg2, peg3);

ConsoleInteractor.ReadConsole(tower);