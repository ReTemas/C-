using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_HW
{
    public class Money
    {
        private int _denomination;
        private int _countOfNote;

        public Money(int denomination, int countOfNote)
        {
            SetDenomination(denomination);
            SetCountOfNote(countOfNote);
        }

        public void SetDenomination(int denomination)
        {
            _denomination = denomination;
        }

        public int GetDenomination() {
            return _denomination;
        }

        public void SetCountOfNote(int countOfNote) {
            _countOfNote = countOfNote;
        }

        public int GetCountOfNote() {
            return _countOfNote;
        }

        public int GetSumm()
        {
            return _denomination * _countOfNote;
        }

        public bool CanIBuy(int priceOfGoods)
        {
            if(priceOfGoods <= _denomination * _countOfNote)
            {
                return true;
            }
            else return false;
        }

        public int HowMuchCanIBuy(int priceOfGoods)
        {
            int countOfGoods = 0;
            int summOfMoney = _denomination * _countOfNote;

            while(priceOfGoods <= summOfMoney)
            {
                summOfMoney -= priceOfGoods;
                countOfGoods++;
            }
            return countOfGoods;
        }
    }
}
 