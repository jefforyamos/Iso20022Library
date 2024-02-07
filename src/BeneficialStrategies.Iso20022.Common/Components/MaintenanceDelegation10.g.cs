﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MaintenanceDelegation10.  ISO2002 ID# _TzTq8Q00EeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the delegation of a maintenance action or maintenance function.
/// </summary>
public partial record MaintenanceDelegation10
     : IIsoXmlSerilizable<MaintenanceDelegation10>
{
    #nullable enable
    
    /// <summary>
    /// Type of delegation action.
    /// </summary>
    public required TerminalManagementAction3Code DelegationType { get; init; } 
    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    public DataSetCategory15Code? MaintenanceService { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _T_V70w00EeqUVL7sB4m7NA
    /// <summary>
    /// Flag to indicate that the delegated maintenance must be performed on a subset of the terminal estate.
    /// </summary>
    public IsoTrueFalseIndicator? PartialDelegation { get; init; } 
    /// <summary>
    /// Subset of the terminal estate for the delegated actions, for instance for pilot or key deactivation). The subset may be expressed as a list of POI or terminal estate subset identifier.
    /// </summary>
    public IsoMax35Text? POISubset { get; init; } 
    /// <summary>
    /// Information for the MTM to build or include delegated actions in the management plan of the POI.
    /// </summary>
    public MaintenanceDelegateAction5? DelegatedAction { get; init; } 
    /// <summary>
    /// Identification of the delegation scope assigned by the MTM.
    /// </summary>
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 
    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 
    /// <summary>
    /// Certificate path of the terminal manager.
    /// </summary>
    public IsoMax10KBinary? Certificate { get; init; } 
    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    public MaintenanceIdentificationAssociation1? POIIdentificationAssociation { get; init; } 
    /// <summary>
    /// Identification of the key to manage or to download.
    /// </summary>
    public KEKIdentifier5? SymmetricKey { get; init; } 
    /// <summary>
    /// Configuration parameters of the terminal manager to be sent by the MTM.
    /// </summary>
    public AcceptorConfigurationDataSet1? ParameterDataSet { get; init; } 
    
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
        writer.WriteStartElement(null, "DlgtnTp", xmlNamespace );
        writer.WriteValue(DelegationType.ToString()); // Enum value
        writer.WriteEndElement();
        // Not sure how to serialize MaintenanceService, multiplicity Unknown
        if (PartialDelegation is IsoTrueFalseIndicator PartialDelegationValue)
        {
            writer.WriteStartElement(null, "PrtlDlgtn", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoTrueFalseIndicator(PartialDelegationValue)); // data type TrueFalseIndicator System.String
            writer.WriteEndElement();
        }
        if (POISubset is IsoMax35Text POISubsetValue)
        {
            writer.WriteStartElement(null, "POISubset", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(POISubsetValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (DelegatedAction is MaintenanceDelegateAction5 DelegatedActionValue)
        {
            writer.WriteStartElement(null, "DlgtdActn", xmlNamespace );
            DelegatedActionValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (DelegationScopeIdentification is IsoMax35Text DelegationScopeIdentificationValue)
        {
            writer.WriteStartElement(null, "DlgtnScpId", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax35Text(DelegationScopeIdentificationValue)); // data type Max35Text System.String
            writer.WriteEndElement();
        }
        if (DelegationScopeDefinition is IsoMax3000Binary DelegationScopeDefinitionValue)
        {
            writer.WriteStartElement(null, "DlgtnScpDef", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax3000Binary(DelegationScopeDefinitionValue)); // data type Max3000Binary System.Byte[]
            writer.WriteEndElement();
        }
        if (Certificate is IsoMax10KBinary CertificateValue)
        {
            writer.WriteStartElement(null, "Cert", xmlNamespace );
            writer.WriteValue(SerializationFormatter.IsoMax10KBinary(CertificateValue)); // data type Max10KBinary System.Byte[]
            writer.WriteEndElement();
        }
        if (POIIdentificationAssociation is MaintenanceIdentificationAssociation1 POIIdentificationAssociationValue)
        {
            writer.WriteStartElement(null, "POIIdAssoctn", xmlNamespace );
            POIIdentificationAssociationValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (SymmetricKey is KEKIdentifier5 SymmetricKeyValue)
        {
            writer.WriteStartElement(null, "SmmtrcKey", xmlNamespace );
            SymmetricKeyValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
        if (ParameterDataSet is AcceptorConfigurationDataSet1 ParameterDataSetValue)
        {
            writer.WriteStartElement(null, "ParamDataSet", xmlNamespace );
            ParameterDataSetValue.Serialize(writer, xmlNamespace);
            writer.WriteEndElement();
        }
    }
    public static MaintenanceDelegation10 Deserialize(XElement element)
    {
        throw new NotImplementedException();
    }
}
