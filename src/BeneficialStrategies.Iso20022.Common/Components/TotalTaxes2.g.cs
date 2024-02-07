﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TotalTaxes2.  ISO2002 ID# _U5QL9dp-Ed-ak6NoX_4Aeg_1827324489.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information regarding the total amount of taxes.
/// </summary>
public partial record TotalTaxes2
     : IIsoXmlSerilizable<TotalTaxes2>
{
    #nullable enable
    
    /// <summary>
    /// Total value of the taxes for a specific order.
    /// </summary>
    public IsoActiveCurrencyAnd13DecimalAmount? TotalAmountOfTaxes { get; init; } 
    /// <summary>
    /// Information related to a specific tax.
    /// </summary>
    public Tax7? TaxDetails { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _U5QL99p-Ed-ak6NoX_4Aeg_1827325403
    
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
        if (TotalAmountOfTaxes is IsoActiveCurrencyAnd13DecimalAmount TotalAmountOfTaxesValue)
        {
            writer.WriteStartElement(null, "TtlAmtOfTaxs", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoActiveCurrencyAnd13DecimalAmount(TotalAmountOfTaxesValue)); // data type ActiveCurrencyAnd13DecimalAmount System.Decimal
            writer.WriteEndElement();
        }
        // Not sure how to serialize TaxDetails, multiplicity Unknown
    }
    public static TotalTaxes2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
