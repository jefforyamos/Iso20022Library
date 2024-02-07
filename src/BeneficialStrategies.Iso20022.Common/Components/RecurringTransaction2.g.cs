﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RecurringTransaction2.  ISO2002 ID# _3s3JETDhEeO9waS4ina8CA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial loan (instalment) or a recurring transaction.
/// </summary>
public partial record RecurringTransaction2
     : IIsoXmlSerilizable<RecurringTransaction2>
{
    #nullable enable
    
    /// <summary>
    /// Type of instalment plan.
    /// </summary>
    public InstalmentPlan1Code? InstalmentPlan { get; init; } 
    /// <summary>
    /// Identification of the instalment plan.
    /// </summary>
    public IsoMax35Text? PlanIdentification { get; init; } 
    /// <summary>
    /// Indicates the recurring/instalment occurrence of the transaction (1 = 1st instalment, 2 = 2nd instalment, etc.).
    /// </summary>
    public IsoNumber? SequenceNumber { get; init; } 
    /// <summary>
    /// Period unit between consecutive payments (for example day, month, year).
    /// </summary>
    public Frequency3Code? PeriodUnit { get; init; } 
    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    public IsoNumber? InstalmentPeriod { get; init; } 
    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    public IsoNumber? TotalNumberOfPayments { get; init; } 
    /// <summary>
    /// Date of the first payment.
    /// </summary>
    public IsoISODate? FirstPaymentDate { get; init; } 
    /// <summary>
    /// Cumulative amount of all the instalments.
    /// </summary>
    public IsoCurrencyAndAmount? TotalAmount { get; init; } 
    /// <summary>
    /// Amount of the first payment.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? FirstAmount { get; init; } 
    /// <summary>
    /// Charges related to the transaction.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? Charges { get; init; } 
    
    #nullable disable
    
    
    /// <summary>
    /// Used to format the various primative types during serialization.
    /// </summary>
    public static SerializationFormatter SerializationFormatter { get; set; } = SerializationFormatter.GlobalInstance;
    
    /// <summary>
    /// Serializes the state of this record according to Iso20022 specifications.
    /// </summary>
    public void Serialize(XmlWriter writer, string xmlNamespace)
    {
        if (InstalmentPlan is InstalmentPlan1Code InstalmentPlanValue)
        {
            writer.WriteStartElement(null, "InstlmtPlan", xmlNamespace );
            writer.WriteValue(InstalmentPlanValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PlanIdentification is IsoMax35Text PlanIdentificationValue)
        {
            writer.WriteStartElement(null, "PlanId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(PlanIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (SequenceNumber is IsoNumber SequenceNumberValue)
        {
            writer.WriteStartElement(null, "SeqNb", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(SequenceNumberValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (PeriodUnit is Frequency3Code PeriodUnitValue)
        {
            writer.WriteStartElement(null, "PrdUnit", xmlNamespace );
            writer.WriteValue(PeriodUnitValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (InstalmentPeriod is IsoNumber InstalmentPeriodValue)
        {
            writer.WriteStartElement(null, "InstlmtPrd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(InstalmentPeriodValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (TotalNumberOfPayments is IsoNumber TotalNumberOfPaymentsValue)
        {
            writer.WriteStartElement(null, "TtlNbOfPmts", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoNumber(TotalNumberOfPaymentsValue)); // data type Number System.UInt64
            writer.WriteEndElement();
        }
        if (FirstPaymentDate is IsoISODate FirstPaymentDateValue)
        {
            writer.WriteStartElement(null, "FrstPmtDt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoISODate(FirstPaymentDateValue)); // data type ISODate System.DateOnly
            writer.WriteEndElement();
        }
        if (TotalAmount is IsoCurrencyAndAmount TotalAmountValue)
        {
            writer.WriteStartElement(null, "TtlAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoCurrencyAndAmount(TotalAmountValue)); // data type CurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (FirstAmount is IsoImpliedCurrencyAndAmount FirstAmountValue)
        {
            writer.WriteStartElement(null, "FrstAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(FirstAmountValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Charges is IsoImpliedCurrencyAndAmount ChargesValue)
        {
            writer.WriteStartElement(null, "Chrgs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoImpliedCurrencyAndAmount(ChargesValue)); // data type ImpliedCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
    }
    public static RecurringTransaction2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
