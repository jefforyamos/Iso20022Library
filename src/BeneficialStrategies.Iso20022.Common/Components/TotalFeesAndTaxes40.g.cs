﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalFeesAndTaxes40.  ISO2002 ID# _VJEXMDh2EeamLZQeccJa7w.
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
public partial record TotalFeesAndTaxes40
     : IIsoXmlSerilizable<TotalFeesAndTaxes40>
{
    #nullable enable
    
    /// <summary>
    /// Total amount of overhead applied to the transaction that impacts the settlement amount.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalOverheadApplied { get; init; } 
    /// <summary>
    /// Total amount of fees (charge/commissions) applied to the transaction that impacts the settlement amount.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalFees { get; init; } 
    /// <summary>
    /// Total amount of taxes applied to the transaction that impacts the settlement amount.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalTaxes { get; init; } 
    /// <summary>
    /// Reference to the agreement established between the fund and another party. This element, amongst others, defines the conditions of the commissions.
    /// </summary>
    public IsoMax35Text? CommercialAgreementReference { get; init; } 
    /// <summary>
    /// Individual fee (charge/commission).
    /// </summary>
    public Fee2? IndividualFee { get; init; } 
    /// <summary>
    /// Individual tax.
    /// </summary>
    public Tax31? IndividualTax { get; init; } 
    
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
        if (TotalOverheadApplied is IsoActiveCurrencyAndAmount TotalOverheadAppliedValue)
        {
            writer.WriteStartElement(null, "TtlOvrhdApld", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalOverheadAppliedValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TotalFees is IsoActiveCurrencyAndAmount TotalFeesValue)
        {
            writer.WriteStartElement(null, "TtlFees", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalFeesValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (TotalTaxes is IsoActiveCurrencyAndAmount TotalTaxesValue)
        {
            writer.WriteStartElement(null, "TtlTaxs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAndAmount(TotalTaxesValue)); // data type ActiveCurrencyAndAmount System.Decimal
            writer.WriteEndElement();
        }
        if (CommercialAgreementReference is IsoMax35Text CommercialAgreementReferenceValue)
        {
            writer.WriteStartElement(null, "ComrclAgrmtRef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(CommercialAgreementReferenceValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (IndividualFee is Fee2 IndividualFeeValue)
        {
            writer.WriteStartElement(null, "IndvFee", xmlNamespace );
            IndividualFeeValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (IndividualTax is Tax31 IndividualTaxValue)
        {
            writer.WriteStartElement(null, "IndvTax", xmlNamespace );
            IndividualTaxValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static TotalFeesAndTaxes40 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
