﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BalanceAmounts4.  ISO2002 ID# _WQIfU9p-Ed-ak6NoX_4Aeg_1080208287.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amounts linked to a securities balance, for example, holding value.
/// </summary>
public partial record BalanceAmounts4
     : IIsoXmlSerilizable<BalanceAmounts4>
{
    #nullable enable
    
    /// <summary>
    /// Value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    public AmountAndDirection14? HoldingValue { get; init; } 
    /// <summary>
    /// Previous value of an individual financial instrument holding within a safekeeping account.
    /// </summary>
    public AmountAndDirection14? PreviousHoldingValue { get; init; } 
    /// <summary>
    /// Value of a financial instrument, as booked/acquired in an account. It may be used to establish capital gain tax liability.
    /// </summary>
    public AmountAndDirection14? BookValue { get; init; } 
    /// <summary>
    /// Value of the position eligible for collateral purposes.
    /// </summary>
    public AmountAndDirection14? EligibleCollateralValue { get; init; } 
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    public AmountAndDirection14? AccruedInterestAmount { get; init; } 
    
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
        if (HoldingValue is AmountAndDirection14 HoldingValueValue)
        {
            writer.WriteStartElement(null, "HldgVal", xmlNamespace );
            HoldingValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (PreviousHoldingValue is AmountAndDirection14 PreviousHoldingValueValue)
        {
            writer.WriteStartElement(null, "PrvsHldgVal", xmlNamespace );
            PreviousHoldingValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BookValue is AmountAndDirection14 BookValueValue)
        {
            writer.WriteStartElement(null, "BookVal", xmlNamespace );
            BookValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (EligibleCollateralValue is AmountAndDirection14 EligibleCollateralValueValue)
        {
            writer.WriteStartElement(null, "ElgblCollVal", xmlNamespace );
            EligibleCollateralValueValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AccruedInterestAmount is AmountAndDirection14 AccruedInterestAmountValue)
        {
            writer.WriteStartElement(null, "AcrdIntrstAmt", xmlNamespace );
            AccruedInterestAmountValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static BalanceAmounts4 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
