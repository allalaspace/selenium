Feature: SouscriptionEmployeur


@ToDoApp
Scenario: SouscriptionEmployeur
	Given Je Suis connecté à l'espace employeur <Browser> and <PlatForm>
	Then Je découvre les offres je sélectionne le boutton découvrir
	Then Je dispose la session

	Examples:
		| Browser        | PlatForm  |
		| chrome         | Linux	 |
		| firefox        | Linux	 |
		| microsoftEdge  | Linux	 |