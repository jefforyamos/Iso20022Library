﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BonusWithdrawal1.  ISO2002 ID# _K37R0F23EeiFXdiLi_Nf4A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a bonus paid out or a withdrawal.
/// </summary>
public partial record BonusWithdrawal1
     : IIsoXmlSerilizable<BonusWithdrawal1>
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the amount is the result of a bonus paid, a withdrawal or other kind of amount.
    /// </summary>
    public required TypeOfAmount1Choice_ TypeOfAmount { get; init; } 
    /// <summary>
    /// Amount of the bonus paid or the claimed amount. For example, a claimed amount for a lifetime ISA (LISA) or a government bonus paid out.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAnd13DecimalAmount? Amount { get; init; } 
    /// <summary>
    /// Reason for the bonus amount paid to or an amount withdrawn from the investment product.
    /// </summary>
    public WithdrawalReason1Choice_? Reason { get; init; } 
    /// <summary>
    /// Amount of an unclaimed bonus or an unclaimed withdrawal.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAnd13DecimalAmount? UnclaimedAmount { get; init; } 
    /// <summary>
    /// Indicates whether there is an outstanding bonus or withdrawal amount.
    /// </summary>
    public IsoYesNoIndicator? Outstanding { get; init; } 
    /// <summary>
    /// Additional information about the monies paid out or withdrawn.
    /// </summary>
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    
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
        writer.WriteStartElement(null, "TpOfAmt", xmlNamespace );
        TypeOfAmount.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Amount is IsoActiveOrHistoricCurrencyAnd13DecimalAmount AmountValue)
        {
            writer.WriteStartElement(null, "Amt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAnd13DecimalAmount(AmountValue)); // data type ActiveOrHistoricCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Reason is WithdrawalReason1Choice_ ReasonValue)
        {
            writer.WriteStartElement(null, "Rsn", xmlNamespace );
            ReasonValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (UnclaimedAmount is IsoActiveOrHistoricCurrencyAnd13DecimalAmount UnclaimedAmountValue)
        {
            writer.WriteStartElement(null, "UclmdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveOrHistoricCurrencyAnd13DecimalAmount(UnclaimedAmountValue)); // data type ActiveOrHistoricCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        if (Outstanding is IsoYesNoIndicator OutstandingValue)
        {
            writer.WriteStartElement(null, "Outsdng", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(OutstandingValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
        if (AdditionalInformation is AdditionalInformation15 AdditionalInformationValue)
        {
            writer.WriteStartElement(null, "AddtlInf", xmlNamespace );
            AdditionalInformationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static BonusWithdrawal1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
