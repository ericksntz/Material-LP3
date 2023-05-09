using ControleAbastec;

var abastecimentos = new Abastecimentos ("Renato Fernandez", 0m);

var gasolina = new Gasolina("Gasolina", 0);
gasolina.AtualizarValor(20, DateTime.Now, "Gasolina Comum");
gasolina.AtualizarValor(50, DateTime.Now, "Gasolina Aditivada");
gasolina.ExecutarAjustes();

Console.WriteLine(gasolina.EmitirRelatorio());

var alcool = new Alcool("Alcool", 0);
alcool.AtualizarValor(100, DateTime.Now, "Alcool Comum");
gasolina.AtualizarValor(50, DateTime.Now, "Alcool Aditivada");
gasolina.AtualizarValor(250, DateTime.Now, "Alcool Anidro");
alcool.ExecutarAjustes();

Console.WriteLine(alcool.EmitirRelatorio());

var diesel = new Diesel("Diesel", 0, -90);
diesel.AtualizarValor(500, DateTime.Now, "Diesel");
diesel.ExecutarAjustes();

Console.WriteLine(diesel.EmitirRelatorio());

var querosene = new Querosene("Querosene", 0);
querosene.AtualizarValor(1000, DateTime.Now, "Querosene");
querosene.ExecutarAjustes();

Console.WriteLine(querosene.EmitirRelatorio());

var nafta = new Nafta("Nafta", 0);
nafta.AtualizarValor(1000, DateTime.Now, "Nafta");
nafta.ExecutarAjustes();

Console.WriteLine(nafta.EmitirRelatorio());

var gnv = new GNV("Gás veicular", 0);
gnv.AtualizarValor(500, DateTime.Now, "GNV");
gnv.ExecutarAjustes();

Console.WriteLine(gnv.EmitirRelatorio());

var diesel_S10 = new Diesel_S10("Diesel S-10", 0);
diesel_S10.AtualizarValor(500, DateTime.Now, "Diesel S-10");
diesel_S10.AtualizarValor(200, DateTime.Now, "Aditivo 10");
diesel_S10.ExecutarAjustes();

Console.WriteLine(diesel_S10.EmitirRelatorio());

var diesel_S8 = new Diesel_S8("Diesel S-8", 0);
diesel_S8.AtualizarValor(550, DateTime.Now, "Diesel S-8");
diesel_S8.AtualizarValor(780, DateTime.Now, "Aditivo 8");
diesel_S8.ExecutarAjustes();

Console.WriteLine(diesel_S8.EmitirRelatorio());


var gas = new Gas("Gás", 0);
gas.AtualizarValor(1360, DateTime.Now, "Gás");
gas.AtualizarValor(500, DateTime.Now, "Bicos Injetores");
gas.AtualizarValor(480, DateTime.Now, "Válvula de Controle");
gas.AtualizarValor(222, DateTime.Now, "Mangueiras");
gas.ExecutarAjustes();

Console.WriteLine(gas.EmitirRelatorio());
