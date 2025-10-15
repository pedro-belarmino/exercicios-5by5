using POO;

Pessoa pessoa = new Pessoa();

pessoa.setNome("Pedrinho das internets");
pessoa.setIdade(21);
pessoa.setCPF("412.423.656.43");
pessoa.setAltura(1.85);

Console.WriteLine(pessoa.getNome());
Console.WriteLine(pessoa.getIdade());
Console.WriteLine(pessoa.getCPF());
Console.WriteLine(pessoa.getAltura());