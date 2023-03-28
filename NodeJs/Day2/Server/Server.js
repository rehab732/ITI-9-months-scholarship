

const Mod = require("../Modules/MyModule");

const tickets = new Mod();


tickets.addTicket(1, "123", "bjbvj", "nlk", "2023-01-01");
tickets.addTicket(2, "456", "jbk", "aaa", "2023-01-01");
tickets.addTicket(3, "489", "alm", "asmdl", "2023-01-01");
tickets.addTicket(4, "889", "alm", "adnma", "2023-01-01");
tickets.addTicket(5, "486", "alm", "asmnlknd", "2023-01-01");


// Display all tickets
tickets.displayTickets();
tickets.updateTicket(4,"888","shk","sknla","2023-01-01")
tickets.getTicket(5)

