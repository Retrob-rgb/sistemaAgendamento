-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Tempo de geração: 14-Nov-2020 às 18:38
-- Versão do servidor: 5.7.31
-- versão do PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `pescaria`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `agenda`
--

DROP TABLE IF EXISTS `agenda`;
CREATE TABLE IF NOT EXISTS `agenda` (
  `id_agenda` int(11) NOT NULL AUTO_INCREMENT,
  `data` date NOT NULL,
  `hora` time NOT NULL,
  `cpf` varchar(15) NOT NULL,
  `crm` varchar(15) NOT NULL,
  `situacao` enum('Agendada','Realizada','Cancelada') DEFAULT 'Agendada',
  `observacao` text,
  PRIMARY KEY (`data`,`hora`,`cpf`),
  KEY `id_agenda` (`id_agenda`),
  KEY `FK_pescador` (`cpf`) USING BTREE,
  KEY `FK_quiosque` (`crm`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `agenda`
--

INSERT INTO `agenda` (`id_agenda`, `data`, `hora`, `cpf`, `crm`, `situacao`, `observacao`) VALUES
(5, '2020-11-23', '11:00:00', '783.458.975-00', '152478', 'Agendada', 'Devera realizar o checkin uma hora antes'),
(4, '2020-11-24', '16:45:00', '783.458.975-00', '152478', 'Agendada', 'Realizar o checkin na portaria antes de utilizar o quiosque.'),
(1, '2020-12-19', '10:30:00', '835.367.598-00', '152480', 'Agendada', 'O quiosque alugado não possui frigobar.');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pescador`
--

DROP TABLE IF EXISTS `pescador`;
CREATE TABLE IF NOT EXISTS `pescador` (
  `cpf` varchar(15) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `telefone` varchar(15) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cpf`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `pescador`
--

INSERT INTO `pescador` (`cpf`, `nome`, `telefone`, `email`) VALUES
('783.458.975-00', 'José da Rosa', '(12)985737-8935', 'josedr@gmail.com'),
('835.367.598-00', 'Fabio Rocha', '(12)84654-7392', 'fabior@gmail.com');

-- --------------------------------------------------------

--
-- Estrutura da tabela `quiosque`
--

DROP TABLE IF EXISTS `quiosque`;
CREATE TABLE IF NOT EXISTS `quiosque` (
  `crm` varchar(15) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `finalidade` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`crm`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `quiosque`
--

INSERT INTO `quiosque` (`crm`, `nome`, `finalidade`) VALUES
('152478', 'Quiosque Agua Salgada', 'Pesca Esportiva'),
('152479', 'Quiosque Lazer Matinal', 'Diversão Familiar'),
('152480', 'Quiosque Barra Funda', 'Pesca Esportiva'),
('152481', 'Quiosque Peixe-Espada', 'Alimentação'),
('152482', 'Quiosque Tainha', 'Pesca Profissional');

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `agenda`
--
ALTER TABLE `agenda`
  ADD CONSTRAINT `FK_pescador` FOREIGN KEY (`cpf`) REFERENCES `pescador` (`cpf`),
  ADD CONSTRAINT `FK_quiosque` FOREIGN KEY (`crm`) REFERENCES `quiosque` (`crm`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
