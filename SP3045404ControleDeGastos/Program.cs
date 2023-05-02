﻿using Classes;
var gasto1 = new Educacao("Erick Brito", 0);
gasto1.EfetuarTransacao(1000, DateTime.Now, "Linguagem C#");
gasto1.MargemDeSeguranca();

Console.WriteLine(gasto1.HistoricoDeGastos());

var gasto2 = new Natacao("Erick Brito", 0);
gasto2.EfetuarTransacao(100, DateTime.Now, "Uniforme");
gasto2.EfetuarTransacao(40, DateTime.Now, "Óculos de Natação");
gasto2.MargemDeSeguranca();

Console.WriteLine(gasto2.HistoricoDeGastos());

var gasto3 = new Judo("Erick Brito", 0);
gasto3.EfetuarTransacao(50, DateTime.Now, "Faixa");
gasto3.EfetuarTransacao(100, DateTime.Now, "Tatame");
gasto3.EfetuarTransacao(250, DateTime.Now, "Kimono");
gasto3.MargemDeSeguranca();

Console.WriteLine(gasto3.HistoricoDeGastos());

var gasto4 = new Danca("Erick Brito", 0);
gasto4.EfetuarTransacao(100, DateTime.Now, "Roupa");
gasto4.EfetuarTransacao(150, DateTime.Now, "Sapato");
gasto4.MargemDeSeguranca();

Console.WriteLine(gasto4.HistoricoDeGastos());