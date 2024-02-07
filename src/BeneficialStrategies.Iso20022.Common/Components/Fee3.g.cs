﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Fee3.  ISO2002 ID# _ouYtsTk2EeapUO0vUIo9Xw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
public partial record Fee3
     : IIsoXmlSerilizable<Fee3>
{
    #nullable enable
    
    /// <summary>
    /// Type of fee (charge/commission).
    /// </summary>
    public ChargeType5Choice_? Type { get; init; } 
    /// <summary>
    /// Modified value of the standard fee (charge/commission) amount applied on the order (the standard fee (charge/commission) amount in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    public IsoActiveCurrencyAndAmount? RepairedStandardAmount { get; init; } 
    /// <summary>
    /// Modified value of the standard fee (charge/commission) rate applied on the order (the standard fee (charge/commission) rate in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    public IsoPercentageRate? RepairedStandardRate { get; init; } 
    /// <summary>
    /// Modified value of the discount amount applied on the order (the discount amount in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    public IsoActiveCurrencyAndAmount? RepairedDiscountAmount { get; init; } 
    /// <summary>
    /// Modified value of the discount rate applied on the order (the discount rate in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    public IsoPercentageRate? RepairedDiscountRate { get; init; } 
    /// <summary>
    /// Modified value of the requested fee (charge/commission) amount applied on the order (the requested fee (charge/commission) amount in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    public IsoActiveCurrencyAndAmount? RepairedRequestedAmount { get; init; } 
    /// <summary>
    /// Modified value of the requested fee (charge/commission) rate applied on the order (the requested fee (charge/commission) rate in the original individual order that has been repaired so that the order can be accepted).
    /// </summary>
    public IsoPercentageRate? RepairedRequestedRate { get; init; } 
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    /// <summary>
    /// Indicates if the CommercialAgreementReference is a new reference or not.
    /// </summary>
    public IsoYesNoIndicator? NewCommercialAgreementReferenceIndicator { get; init; } 
    
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
        if (Type is ChargeType5Choice_ TypeValue)
        {
            writer.WriteStartElement(null, "Tp", xmlNamespace );
            TypeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (RepairedStandardAmount is IsoActiveCurrencyAndAmount RepairedStandardAmountValue)
        {
            writer.WriteStartElement(null, "RprdStdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(RepairedStandardAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (RepairedStandardRate is IsoPercentageRate RepairedStandardRateValue)
        {
            writer.WriteStartElement(null, "RprdStdRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(RepairedStandardRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (RepairedDiscountAmount is IsoActiveCurrencyAndAmount RepairedDiscountAmountValue)
        {
            writer.WriteStartElement(null, "RprdDscntAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(RepairedDiscountAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (RepairedDiscountRate is IsoPercentageRate RepairedDiscountRateValue)
        {
            writer.WriteStartElement(null, "RprdDscntRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(RepairedDiscountRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (RepairedRequestedAmount is IsoActiveCurrencyAndAmount RepairedRequestedAmountValue)
        {
            writer.WriteStartElement(null, "RprdReqdAmt", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(RepairedRequestedAmountValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (RepairedRequestedRate is IsoPercentageRate RepairedRequestedRateValue)
        {
            writer.WriteStartElement(null, "RprdReqdRate", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoPercentageRate(RepairedRequestedRateValue)); // data type PercentageRate System.Decimal
            writer.WriteEndElement();
        }
        if (CommercialAgreementReference is IsoMax35Text CommercialAgreementReferenceValue)
        {
            writer.WriteStartElement(null, "ComrclAgrmtRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CommercialAgreementReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (NewCommercialAgreementReferenceIndicator is IsoYesNoIndicator NewCommercialAgreementReferenceIndicatorValue)
        {
            writer.WriteStartElement(null, "NewComrclAgrmtRefInd", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoYesNoIndicator(NewCommercialAgreementReferenceIndicatorValue)); // data type YesNoIndicator System.String
            writer.WriteEndElement();
        }
    }
    public static Fee3 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
