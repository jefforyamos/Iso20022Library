﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionOption175.  ISO2002 ID# _pT7v4AVTEeqjd8n6wD9JVw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action option.
/// </summary>
public partial record CorporateActionOption175
     : IIsoXmlSerilizable<CorporateActionOption175>
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    public required CorporateActionOption39Choice_ OptionType { get; init; } 
    /// <summary>
    /// Provides information about the securities movement linked to the corporate action option.
    /// </summary>
    public SecuritiesOption69? SecuritiesMovementDetails { get; init; } 
    /// <summary>
    /// Provides information about the cash movement related to a corporate action option.
    /// </summary>
    public CashOption62? CashMovementDetails { get; init; } 
    
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
        writer.WriteStartElement(null, "OptnNb", xmlNamespace );
        OptionNumber.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "OptnTp", xmlNamespace );
        OptionType.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (SecuritiesMovementDetails is SecuritiesOption69 SecuritiesMovementDetailsValue)
        {
            writer.WriteStartElement(null, "SctiesMvmntDtls", xmlNamespace );
            SecuritiesMovementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CashMovementDetails is CashOption62 CashMovementDetailsValue)
        {
            writer.WriteStartElement(null, "CshMvmntDtls", xmlNamespace );
            CashMovementDetailsValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionOption175 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
