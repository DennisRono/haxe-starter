<?php
/**
 */

use \php\Boot;

class Main {
	/**
	 * @return void
	 */
	public static function main () {
		#Main.hx:3: characters 7-36
		echo("Haxe is great!" . PHP_EOL);
	}

	/**
	 * @return void
	 */
	public function __construct () {
	}
}

Boot::registerClass(Main::class, 'Main');
