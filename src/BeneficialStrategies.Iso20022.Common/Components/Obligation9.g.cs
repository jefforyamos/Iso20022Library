﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Obligation9.  ISO2002 ID# _wc_c4SgsEeyB747fKu7_rw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
/// </summary>
public partial record Obligation9
     : IIsoXmlSerilizable<Obligation9>
{
    #nullable enable
    
    /// <summary>
    /// Defines one of the entities associated with the collateral agreement.
    /// </summary>
    public required PartyIdentification178Choice_ PartyA { get; init; } 
    /// <summary>
    /// Specifies the party that is acting on behalf of party A and that offers collateral management services.
    /// </summary>
    public PartyIdentification178Choice_? ServicingPartyA { get; init; } 
    /// <summary>
    /// Defines the other entity associated with the collateral agreement.
    /// </summary>
    public required PartyIdentification178Choice_ PartyB { get; init; } 
    /// <summary>
    /// Specifies the party that is acting on behalf of party B and that offers collateral management services.
    /// </summary>
    public PartyIdentification178Choice_? ServicingPartyB { get; init; } 
    /// <summary>
    /// Provides additional information on the collateral account of the party delivering/receiving the collateral.
    /// </summary>
    public CollateralAccount3? CollateralAccountIdentification { get; init; } 
    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of collateral account for digital assets.
    /// </summary>
    public BlockChainAddressWallet5? BlockChainAddressOrWallet { get; init; } 
    /// <summary>
    /// Specifies the underlying business area or type of trade causing the collateral movement.
    /// </summary>
    public ExposureType11Code? ExposureType { get; init; } 
    /// <summary>
    /// Indicates the close of business date on which the initiating party is valuing the margin call.
    /// </summary>
    public required DateAndDateTime2Choice_ ValuationDate { get; init; } 
    
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
        writer.WriteStartElement(null, "PtyA", xmlNamespace );
        PartyA.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ServicingPartyA is PartyIdentification178Choice_ ServicingPartyAValue)
        {
            writer.WriteStartElement(null, "SvcgPtyA", xmlNamespace );
            ServicingPartyAValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "PtyB", xmlNamespace );
        PartyB.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (ServicingPartyB is PartyIdentification178Choice_ ServicingPartyBValue)
        {
            writer.WriteStartElement(null, "SvcgPtyB", xmlNamespace );
            ServicingPartyBValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (CollateralAccountIdentification is CollateralAccount3 CollateralAccountIdentificationValue)
        {
            writer.WriteStartElement(null, "CollAcctId", xmlNamespace );
            CollateralAccountIdentificationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (BlockChainAddressOrWallet is BlockChainAddressWallet5 BlockChainAddressOrWalletValue)
        {
            writer.WriteStartElement(null, "BlckChainAdrOrWllt", xmlNamespace );
            BlockChainAddressOrWalletValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ExposureType is ExposureType11Code ExposureTypeValue)
        {
            writer.WriteStartElement(null, "XpsrTp", xmlNamespace );
            writer.WriteValue(ExposureTypeValue.ToString()); // Enum value
            writer.WriteEndElement();
        }
        writer.WriteStartElement(null, "ValtnDt", xmlNamespace );
        ValuationDate.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
    }
    public static Obligation9 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
