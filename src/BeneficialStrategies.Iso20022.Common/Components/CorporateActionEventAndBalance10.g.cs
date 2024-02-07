﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionEventAndBalance10.  ISO2002 ID# _cfq2c5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Detailed account holdings information report for a corporate action event.
/// </summary>
public partial record CorporateActionEventAndBalance10
     : IIsoXmlSerilizable<CorporateActionEventAndBalance10>
{
    #nullable enable
    
    /// <summary>
    /// Provides general information related to a corporate action event.
    /// </summary>
    public required EventInformation8 GeneralInformation { get; init; } 
    /// <summary>
    /// Security concerned by the corporate action.
    /// </summary>
    public required SecurityIdentification20 UnderlyingSecurity { get; init; } 
    /// <summary>
    /// Provides information about the balance related to a corporate action.
    /// </summary>
    public CorporateActionBalanceDetails33? Balance { get; init; } 
    /// <summary>
    /// Provides additional information related to the event and the balance of the corporate action.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init; } 
    
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
        writer.WriteStartElement(null, "GnlInf", xmlNamespace );
        GeneralInformation.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        writer.WriteStartElement(null, "UndrlygScty", xmlNamespace );
        UnderlyingSecurity.Serialize(writer, xmlNamespace);
        writer.WriteEndElement();
        if (Balance is CorporateActionBalanceDetails33 BalanceValue)
        {
            writer.WriteStartElement(null, "Bal", xmlNamespace );
            BalanceValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SupplementaryData is SupplementaryData1 SupplementaryDataValue)
        {
            writer.WriteStartElement(null, "SplmtryData", xmlNamespace );
            SupplementaryDataValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static CorporateActionEventAndBalance10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
