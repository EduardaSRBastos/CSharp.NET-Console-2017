using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Exercicio1
{
    class DataCronologica
    {int dia, mes, ano;
        public DataCronologica(int d,int m,int a)
        {dia = d;
            mes = m;
            ano = a;}
        public int di
        {
            get { return dia; }
            set { dia = value; }
        }
        public int me
        {
            get { return mes; }
            set { mes = value; }
        }
        public int an
        {
            get { return ano; }
            set { ano = value; }
        }
        public int idade()
        {
            int idadeAno=0;
            int anoAtual = DateTime.Now.Year;
            if (DateTime.Now.Month>mes)
            {idadeAno =anoAtual - ano;}
            else
            {anoAtual--;
                idadeAno = anoAtual - ano;}
            return idadeAno;}
        public int idade(int ano)
        {
            int anoHo = 0;
            int total = 0;
            DateTime inicio = new DateTime(ano, 1, 1);
            DateTime DataAtual = DateTime.Now;
            TimeSpan iniANasc;
            TimeSpan iniData = new TimeSpan(0, 0, 0);
            int totalini,totalAno;
            DateTime dataNasc = new DateTime(ano, mes, dia);
            if(ano==DateTime.Now.Year)
            {
                iniANasc = dataNasc.Subtract(inicio);
                totalini=Convert.ToInt32(iniANasc.TotalDays);
                iniData = DataAtual - inicio;
                totalAno = Convert.ToInt32(iniData.TotalDays);
                total = totalAno - totalini;
            }
            else
                {
                DateTime fim = new DateTime(ano, 12, 31);
                DateTime iniAno = new DateTime(DateTime.Now.Year, 1, 1);
                DateTime anoHoje = new DateTime(DateTime.Now.Year);
                TimeSpan fimANasc;
                anoHo=Convert.ToInt32(anoHoje.Ticks);
                int totalHoje=0;               
                fimANasc = fim.Subtract(dataNasc);             
           for(int i=ano;i <= anoHo;i++)
                {
                    if(bissexto(i))
                    {
                        totalHoje += 366;  
                    }
                    else
                    {
                        totalHoje += 365;
                    }
                }
                total = Convert.ToInt32(iniData) + Convert.ToInt32(totalHoje) + Convert.ToInt32(fimANasc);
            }
            return total;
        }
        public bool bissexto(int ano)
        {
            bool bissextoo;
            if((ano % 4==0) &&(ano %100!=0)||(ano %400==0))
            {
                bissextoo = true;
            }
            else { bissextoo = false; }
                return bissextoo ;
        }
    }
}
