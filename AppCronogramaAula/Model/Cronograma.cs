using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCronogramaAula.Model
{
    class Cronograma

    {
        private static int codigo;
        private static int codigoUcFk;
        private static int codigoTurmaFk;
        private static int CodigoSalaFk;
        private static int CodigoProFK;
        private static DateTime dataAula;
        private static string retorno;

        public static int Codigo { get => codigo; set => codigo = value; }
        public static int CodigoUcFk { get => codigoUcFk; set => codigoUcFk = value; }
        public static int CodigoTurmaFk { get => codigoTurmaFk; set => codigoTurmaFk = value; }
        public static int CodigoSalaFk1 { get => CodigoSalaFk; set => CodigoSalaFk = value; }
        public static int CodigoProFK1 { get => CodigoProFK; set => CodigoProFK = value; }
        public static DateTime DataAula { get => dataAula; set => dataAula = value; }
        public static string Retorno { get => retorno; set => retorno = value; }
    }
}
