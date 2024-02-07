﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubBalanceInformation2.  ISO2002 ID# _QY60U9p-Ed-ak6NoX_4Aeg_-1856391421.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
public partial record SubBalanceInformation2
     : IIsoXmlSerilizable<SubBalanceInformation2>
{
    #nullable enable
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public required SubBalanceQuantity1Choice_ Quantity { get; init; } 
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    public required SecuritiesBalanceType1Code SubBalanceType { get; init; } 
    /// <summary>
    /// Reason a security is not available or additional information about the financial instrument for which the balance is given, for example, unregistered, registered in nominee name.
    /// </summary>
    public required IsoExtended350Code ExtendedSubBalanceType { get; init; } 
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    public AdditionalBalanceInformation2? AdditionalBalanceBreakdownDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "Qty", xmlNamespace );
        Quantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "SubBalTp", xmlNamespace );
        writer.WriteValue(SubBalanceType.ToString()); // Enum value
        writer.WriteEndElement();
        writer.WriteStartElement(null, "XtndedSubBalTp", xmlNamespace );
        writer.WriteValue(SerializationFormatter.IsoExtended350Code(ExtendedSubBalanceType)); // data type Extended350Code System.String
        writer.WriteEndElement();
        if (AdditionalBalanceBreakdownDetails is AdditionalBalanceInformation2 AdditionalBalanceBreakdownDetailsValue)
        {
            writer.WriteStartElement(null, "AddtlBalBrkdwnDtls", xmlNamespace );
            AdditionalBalanceBreakdownDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SubBalanceInformation2 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
