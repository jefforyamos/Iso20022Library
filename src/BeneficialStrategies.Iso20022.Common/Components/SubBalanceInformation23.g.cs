﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubBalanceInformation23.  ISO2002 ID# _ciAolzi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, for example sub-balance per status.
/// </summary>
public partial record SubBalanceInformation23
     : IIsoXmlSerilizable<SubBalanceInformation23>
{
    #nullable enable
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    public required SubBalanceType13Choice_ SubBalanceType { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public required SubBalanceQuantity9Choice_ Quantity { get; init; } 
    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    public IsoRestrictedFINXMax140Text? SubBalanceAdditionalDetails { get; init; } 
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    public AdditionalBalanceInformation23? AdditionalBalanceBreakdownDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "SubBalTp", xmlNamespace );
        SubBalanceType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "Qty", xmlNamespace );
        Quantity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SubBalanceAdditionalDetails is IsoRestrictedFINXMax140Text SubBalanceAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "SubBalAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoRestrictedFINXMax140Text(SubBalanceAdditionalDetailsValue)); // data type RestrictedFINXMax140Text System.String
            writer.WriteEndElement();
        }
        if (AdditionalBalanceBreakdownDetails is AdditionalBalanceInformation23 AdditionalBalanceBreakdownDetailsValue)
        {
            writer.WriteStartElement(null, "AddtlBalBrkdwnDtls", xmlNamespace );
            AdditionalBalanceBreakdownDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SubBalanceInformation23 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
