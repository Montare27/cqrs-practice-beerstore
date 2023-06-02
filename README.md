# Beer Store ❝The Schooner Osterreich❞.
Just simple WebApi for my own practice.
<p>The most used technologies here: MediatR(CQRS), EF Core, AutoMapper.
<p>Some words about Architecture:
<ul><h4>As main I used Onion, that devides on modules:</h4></ul>
  <li>Domain: contains main model Beer;</li>
  <li>Application: general application logic, contains all MediatR and AutoMapper logics;</li>
  <li>Infrastructure: database logic;</li>
  <li>Presentation: WebApi application.</li>
