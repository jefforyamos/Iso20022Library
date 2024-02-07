﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubBalanceInformation11.  ISO2002 ID# _mKunaQ0qEeK9as54HthO0w.
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
public partial record SubBalanceInformation11
     : IIsoXmlSerilizable<SubBalanceInformation11>
{
    #nullable enable
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    public required SubBalanceType5Choice_ SubBalanceType { get; init; } 
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public required SubBalanceQuantity3Choice_ Quantity { get; init; } 
    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    public IsoMax140Text? SubBalanceAdditionalDetails { get; init; } 
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    public QuantityBreakdown23? QuantityBreakdown { get; init; } 
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    public AdditionalBalanceInformation11? AdditionalBalanceBreakdownDetails { get; init; } 
    
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
        if (SubBalanceAdditionalDetails is IsoMax140Text SubBalanceAdditionalDetailsValue)
        {
            writer.WriteStartElement(null, "SubBalAddtlDtls", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax140Text(SubBalanceAdditionalDetailsValue)); // data type Max140Text System.String
            writer.WriteEndElement();
        }
        if (QuantityBreakdown is QuantityBreakdown23 QuantityBreakdownValue)
        {
            writer.WriteStartElement(null, "QtyBrkdwn", xmlNamespace );
            QuantityBreakdownValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (AdditionalBalanceBreakdownDetails is AdditionalBalanceInformation11 AdditionalBalanceBreakdownDetailsValue)
        {
            writer.WriteStartElement(null, "AddtlBalBrkdwnDtls", xmlNamespace );
            AdditionalBalanceBreakdownDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static SubBalanceInformation11 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
