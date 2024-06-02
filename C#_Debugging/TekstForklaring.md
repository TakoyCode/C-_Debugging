# Debugging

Debugging i C# referer til prosessen med å identifisere, isolere og rette feil i koden.
Dette er en gyllen mulighet til å forstå hvordan programmet ditt oppfører seg
og løse eventuelle problemer som oppstår under kjøring.

- **Breakpoint** brukes til å stoppe utførelsen av programmet på et bestemt punkt.
	Dette gir den muligheten til å inspisere variabler og undersøke tilstanden til programmet.

- **Step Into, Step Over, og Step out** blir brukt under debugging for å gå igjennom koden trinnvis.
	*Step Into* tar deg inn i funksjonen, *Step Over* utfører funksjonen uten å gå inn i det og
	*Step Out* fullfører gjeldene funksjon og går ut til kalleren.

- **Watch**-vinduet lar deg overvåke verdien av variabler i sanntid mens programmet kjører eller er satt på pause. 
    <a href="https://learn.microsoft.com/en-us/visualstudio/debugger/watch-and-quickwatch-windows?view=vs-2022">Mer info om Watch her!<a>

- **Output**-vinduet viser informasjon fra debuggings-prosessen,
	for eksempel feilmeldinger, utskrift av verder, osv.

- **Exception Handling** er å implementere riktig håndtering av unntak (exceptions),
	som hjelper med å fange og håndtere feil på en kontrollert måte, slik at programmet ikke krasjer.

- **Conditional Breakpoints** er en betinget breakpoint, som utføres hvis en hvis kriterier er oppfylt.

- **Immediate Window** gir deg muligheten til å evaluere uttrykk eller endre variabler men du er midt i debugging. 							
    <a href="https://learn.microsoft.com/en-us/visualstudio/ide/reference/immediate-window?view=vs-2022">Mer info om Immediate Window her!<a>