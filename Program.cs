using BibliotecaClases;

Clinica clinica = new Clinica();

Persona persona_1 = new Persona("Pepito_1", 32123645);
Persona persona_2 = new Persona("Pepito_2", 54634231);
Persona persona_3 = new Persona("Pepito_3", 87634765);
Persona persona_4 = new Persona("Pepito_4", 12387636);
Persona persona_5 = new Persona("Pepito_5", 98123534);
Persona persona_6 = new Persona("Pepito_6", 76194341);
Persona persona_7 = new Persona("Pepito_7", 45123654);

Mascota mascota_1 = new Mascota("Mascota_1", 4, persona_1);
Mascota mascota_2 = new Mascota("Mascota_1", 2, persona_2);
Mascota mascota_3 = new Mascota("Mascota_1", 3, persona_3);
Mascota mascota_4 = new Mascota("Mascota_1", 1, persona_4);
Mascota mascota_5 = new Mascota("Mascota_1", 7, persona_5);
Mascota mascota_6 = new Mascota("Mascota_1", 1, persona_6);
Mascota mascota_7 = new Mascota("Mascota_1", 3, persona_7);

Veterinario veterinario_1 = new Veterinario("Veterianrio_1", 1324);
Veterinario veterinario_2 = new Veterinario("Veterianrio_2", 4351);
Veterinario veterinario_3 = new Veterinario("Veterianrio_3", 8762);
Veterinario veterinario_4 = new Veterinario("Veterianrio_4", 7543);

Turno turno_1 = new Turno(persona_1, mascota_1);
Turno turno_2 = new Turno(persona_2, mascota_2);
Turno turno_3 = new Turno(persona_3, mascota_3);
Turno turno_4 = new Turno(persona_4, mascota_4);
Turno turno_5 = new Turno(persona_5, mascota_5);
Turno turno_6 = new Turno(persona_6, mascota_6);
Turno turno_7 = new Turno(persona_7, mascota_7);

clinica.Turnos.Add(turno_1);

// Verificar cambio