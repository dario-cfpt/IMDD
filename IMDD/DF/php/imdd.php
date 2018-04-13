<?php
/**
 * Created by PhpStorm.
 * User: peiryd_info
 * Date: 13.04.2018
 * Time: 09:08
 */

class IMDD
{
    const DEFAULT_COLUMNS = 3;
    const DEFAULT_ROWS = 3;
    const MODES = array("Tic Tac Toe","Taquin","Snake");

    private static $_objInstance;

    private $_cols;
    private $_rows;
    private $_mode;

    private function __construct()
    {
        $this->setCols(self::DEFAULT_COLUMNS);
        $this->setRows(self::DEFAULT_ROWS);
    }

    public static function getInstance()
    {
        if (!self::$_objInstance) {
            try {
                self::$_objInstance = new IMDD();
            } catch (Exception $e) {
                echo "IMDD Error: " . $e->getMessage();
            }
        }
        return self::$_objInstance;
    }

    public function getCols()
    {
        return $this->_cols;
    }

    public function setCols($n)
    {
        $this->_cols = $n;
    }

    public function getRows()
    {
        return $this->_rows;
    }

    public function setRows($n)
    {
        $this->_rows = $n;
    }

    public function getMode(){
        return $this->_mode;
    }

    public function setMode($m){
        $this->_mode = $m;
    }
}