﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ChargesRecord2.  ISO2002 ID# _c1FRUSHBEeK_0OuuIoS2mw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further individual record details on the charges related to the payment transaction.
/// </summary>
public partial record ChargesRecord2
     : IIsoXmlSerilizable<ChargesRecord2>
{
    #nullable enable
    
    /// <summary>
    /// Transaction charges to be paid by the charge bearer.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Indicates whether the charges amount is a credit or a debit amount. |Usage: A zero amount is considered to be a credit.
    /// </summary>
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Indicates whether the charge should be included in the amount or is added as pre-advice.
    /// </summary>
    public IsoChargeIncludedIndicator? ChargeIncludedIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of charge.
    /// </summary>
    public ChargeType3Choice_? Type { get; init; } 
    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    public IsoPercentageRate? Rate { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public ChargeBearerType1Code? Bearer { get; init; } 
    /// <summary>
    /// Agent that takes the transaction charges or to which the transaction charges are due.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? Agent { get; init; } 
    /// <summary>
    /// Provides details on the tax applied to charges.
    /// </summary>
    public TaxCharges2? Tax { get; init; } 
    
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
        writer.WriteStartElement(null, "Amt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAndAmount(Amount)); // data type ActiveOrHistoricCurrencyAndAmount System.Decimal
        writer.WriteEndElement();
        if (CreditDebitIndicator is CreditDebitCode CreditDebitIndicatorValue)
        {
            writer.WriteStartElement(null, "CdtDbtInd", xmlNamespace );
            writer.WriteValue(CreditDebitIndicatorValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (ChargeIncludedIndicator is IsoChargeIncludedIndicator ChargeIncludedIndicatorValue)
        {
            writer.WriteStartElement(null, "ChrgInclInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoChargeIncludedIndicator(ChargeIncludedIndicatorValue)); // data type ChargeIncludedIndicator System.String
            writer.WriteEndElement();
        }
        if (Type is ChargeType3Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Rate is IsoPercentageRate RateValue)
        {
            writer.WriteStartElement(null, "Rate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(RateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (Bearer is ChargeBearerType1Code BearerValue)
        {
            writer.WriteStartElement(null, "Br", xmlNamespace );
            writer.WriteValue(BearerValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        if (Agent is BranchAndFinancialInstitutionIdentification5 AgentValue)
        {
            writer.WriteStartElement(null, "Agt", xmlNamespace );
            AgentValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (Tax is TaxCharges2 TaxValue)
        {
            writer.WriteStartElement(null, "Tax", xmlNamespace );
            TaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static ChargesRecord2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
