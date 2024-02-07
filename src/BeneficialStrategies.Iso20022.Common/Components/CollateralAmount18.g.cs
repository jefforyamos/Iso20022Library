﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralAmount18.  ISO2002 ID# _qXrlIRIrEeyZaPkaPAzTvQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deal amount details.
/// </summary>
public partial record CollateralAmount18
     : IIsoXmlSerilizable<CollateralAmount18>
{
    #nullable enable
    
    /// <summary>
    /// Amount of the principal. 
    /// </summary>
    public AmountAndDirection49? Transaction { get; init; } 
    /// <summary>
    /// Amount of principal plus interests at termination.
    /// </summary>
    public AmountAndDirection49? Termination { get; init; } 
    /// <summary>
    /// Specifies the accrued interest on the value of the principal trade, in the currency of the principal trade.
    /// </summary>
    public AmountAndDirection49? Accrued { get; init; } 
    /// <summary>
    /// Specifies whether the interest calculation method is simple or compounding.
    /// </summary>
    public CalculationMethod1Code? CompoundSimpleAccrualCalculation { get; init; } 
    /// <summary>
    /// Specifies when the accrued interest is paid.
    /// </summary>
    public Frequency38Choice_? PaymentFrequency { get; init; } 
    /// <summary>
    /// Number of days after the accrual payment is due.
    /// </summary>
    public IsoMax3NumericText? InterestPaymentDelay { get; init; } 
    /// <summary>
    /// Breakdown of transaction amount (required value for the exposure)  into market value lots based on the underlying trades.
    /// </summary>
    public CollateralTransactionAmountBreakdown2? TransactionAmountBreakdown { get; init; } 
    /// <summary>
    /// Value of collateral offered or sought. 
    /// </summary>
    public AmountAndDirection49? ValueSought { get; init; } 
    
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
        if (Transaction is AmountAndDirection49 TransactionValue)
        {
            writer.WriteStartElement(null, "Tx", xmlNamespace );
            TransactionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Termination is AmountAndDirection49 TerminationValue)
        {
            writer.WriteStartElement(null, "Termntn", xmlNamespace );
            TerminationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Accrued is AmountAndDirection49 AccruedValue)
        {
            writer.WriteStartElement(null, "Acrd", xmlNamespace );
            AccruedValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CompoundSimpleAccrualCalculation is CalculationMethod1Code CompoundSimpleAccrualCalculationValue)
        {
            writer.WriteStartElement(null, "CmpndSmplAcrlClctn", xmlNamespace );
            writer.WriteValue(CompoundSimpleAccrualCalculationValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (PaymentFrequency is Frequency38Choice_ PaymentFrequencyValue)
        {
            writer.WriteStartElement(null, "PmtFrqcy", xmlNamespace );
            PaymentFrequencyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (InterestPaymentDelay is IsoMax3NumericText InterestPaymentDelayValue)
        {
            writer.WriteStartElement(null, "IntrstPmtDely", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3NumericText(InterestPaymentDelayValue)); // data type Max3NumericText System.String
            writer.WriteEndElement();
        }
        if (TransactionAmountBreakdown is CollateralTransactionAmountBreakdown2 TransactionAmountBreakdownValue)
        {
            writer.WriteStartElement(null, "TxAmtBrkdwn", xmlNamespace );
            TransactionAmountBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ValueSought is AmountAndDirection49 ValueSoughtValue)
        {
            writer.WriteStartElement(null, "ValSght", xmlNamespace );
            ValueSoughtValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CollateralAmount18 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
