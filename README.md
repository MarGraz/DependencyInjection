# Dependency Injection

<b>Che cos'è la Dependency Injection in C#?</b>

Dependency Injection (DI) è un design pattern della programmazione orientata agli oggetti il cui scopo è quello di semplificare lo sviluppo e migliorare la testabilità di software di grandi dimensioni. 
Con l'aiuto della DI possiamo scrivere un codice "loosely coupled", ossia libero da dipendenze strette tra le varie classi. A differenza di un codice "tightly coupled" che comporterebbe invece, anche per una minima modifica, la necessità di rivedere il funzionamento di tutte le classi dipendenti, anche se non direttamente coinvolte dalla specifica modifica. Un codice loosely coupled, quindi, consente a tutte le classi di lavorare in modo indipendente senza fare affidamento l'una sull'altra.

Questi i tipi di DI che tratteremo:
<ol>
  <li>Constructor Injection</li>  
  <li>Setter or property Injection</li>
  <li>Method Injection</li>
</ol>

Il primo esempio riguarderà un codice scritto in modo "tightly coupled".
