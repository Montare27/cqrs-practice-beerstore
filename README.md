# Beer Store ❝The Schooner Osterreich❞.
Just simple WebApi for my own practice.
The most used technologies here: MediatR(CQRS), EF Core, AutoMapper.
Some words about Architecture:
### As main I used Onion, that devides on modules:
  + Domain: contains main model Beer;
  + Application: general application logic, contains all MediatR and AutoMapper logics;
  + Infrastructure: database logic;
  + Presentation: WebApi application.
