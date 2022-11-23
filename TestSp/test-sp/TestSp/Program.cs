using TestSp.Class;

Element info3 = new An("Informatica 3");
Element grupa1 = new Grupa("Grupa 1");
info3.add(grupa1);
Element sg1 = new Semigrupa("Semigrupa 1");
sg1.add(new Student("Student1", "email"));
sg1.add(new Student("Student2", "email"));
grupa1.add(sg1);
Element sg2 = new Semigrupa("Semigrupa 2");
sg2.add(new Student("Student3", "email"));
sg2.add(new Student("Student4", "email"));
grupa1.add(sg2);
Element grupa2 = new Grupa("Grupa2");
info3.add(grupa2);

Visitor printVisitor = new PrintVisitor();
info3.accept(printVisitor);