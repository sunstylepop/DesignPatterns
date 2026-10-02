// See https://aka.ms/new-console-template for more information


using Factory;

var spawner1 = new ForestSpawner();
var forestMonster = spawner1.CreateMonster();
forestMonster.Appear();

var spawner2 = new VolcanoSpawner();
var VolcanoMonster = spawner2.CreateMonster();
VolcanoMonster.Appear();

var spawner3 = new GlacierSpawner();
var GlacierMonster = spawner3.CreateMonster();
GlacierMonster.Appear();
