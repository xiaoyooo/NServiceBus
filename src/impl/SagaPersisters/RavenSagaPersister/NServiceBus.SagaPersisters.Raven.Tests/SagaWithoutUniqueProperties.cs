namespace NServiceBus.SagaPersisters.Raven.Tests
{
    using System;
    using Saga;

    public class SagaWithoutUniqueProperties : ISagaEntity
    {
        public virtual Guid Id { get; set; }

        public virtual string Originator { get; set; }

        public virtual string OriginalMessageId { get; set; }

        public virtual string UniqueString { get; set; }

        public string NonUniqueString { get; set; }
    }
}