﻿namespace Domain.Entities
{
    public class Transaction<T> : TransactionBase where T : new()
    {
        public T PaymentObject { get; set; }

    }
}
