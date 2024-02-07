﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for InterestResult1.  ISO2002 ID# _SQuqh9p-Ed-ak6NoX_4Aeg_1199217791.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Consideration, such as amount of money, paid or received in exchange for an amount of money that has been invested, loaned or borrowed for a certain period.
/// </summary>
public partial record InterestResult1
     : IIsoXmlSerilizable<InterestResult1>
{
    #nullable enable
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    public IsoActiveCurrencyAndAmount? InterestDueToA { get; init; } 
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    public IsoActiveCurrencyAndAmount? InterestDueToB { get; init; } 
    /// <summary>
    /// Agreed date for the interest payment.
    /// </summary>
    public required IsoISODate ValueDate { get; init; } 
    /// <summary>
    /// Indicates whether the interest will be settled in cash or rolled in the existing collateral balance.
    /// </summary>
    public required InterestMethod1Code InterestMethod { get; init; } 
    /// <summary>
    /// Provides details about the opening collateral balance.
    /// </summary>
    public CollateralBalance1? OpeningCollateralBalance { get; init; } 
    /// <summary>
    /// Provides details about the closing collateral balance.
    /// </summary>
    public required CollateralBalance1 ClosingCollateralBalance { get; init; } 
    
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
        if (InterestDueToA is IsoActiveCurrencyAndAmount InterestDueToAValue)
        {
            writer.WriteStartElement(null, "IntrstDueToA", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(InterestDueToAValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (InterestDueToB is IsoActiveCurrencyAndAmount InterestDueToBValue)
        {
            writer.WriteStartElement(null, "IntrstDueToB", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(InterestDueToBValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ValDt", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoISODate(ValueDate)); // data type ISODate System.DateOnly
        writer.WriteEndElement();
        writer.WriteStartElement(null, "IntrstMtd", xmlNamespace );
        writer.WriteValue(InterestMethod.ToString()); // Enum value
        writer.WriteEndElement();
        if (OpeningCollateralBalance is CollateralBalance1 OpeningCollateralBalanceValue)
        {
            writer.WriteStartElement(null, "OpngCollBal", xmlNamespace );
            OpeningCollateralBalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ClsgCollBal", xmlNamespace );
        ClosingCollateralBalance.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static InterestResult1 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
