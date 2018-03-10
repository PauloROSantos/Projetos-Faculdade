<?php function topo{
	echo ' <html>
			<head>
				<title>Construção de interface em HTML e CSS</title>
				<meta charset="UTF-8">
				<style type="text/css">
				@import "estilo/layout.css";
			</style>
			</head>
			<body>
			';
	}?>
	
<?php function pagina_inicial{
			echo '	<div id="container">
					<header>
					<h1>The Door</h1>
					</header>
					<div id="login">
						<ol>
					<li><a href="">Login</a></li>
						</ol>
					</div>
					<nav>
						<ol>
							<li><a href="">Principal</a></li>
							<li><a href="">Faculdade</a></li>
							<li><a href="">Links</a></li>
							<li><a href="">Outros</a></li>
						</ol>
					</nav>
					</div>
					</body> ';
				}?>
			
<?php function rodape{
			echo '	<footer>Development by <h4>Rafael<h4></footer>

					</body>
					</html>';
					
					}?>
				
