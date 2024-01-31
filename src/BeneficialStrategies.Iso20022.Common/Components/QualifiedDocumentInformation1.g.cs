﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QualifiedDocumentInformation1.  ISO2002 ID# _OTgzMjA0-AOSNFX-8224491.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies an identification of a document assigned by and relative to the issuing party (of the identification).
/// Optionally, the component can contain a copy of the identified document and a URI/URL (Universal Resource Information/Location) facilitating retrieval of the document.
/// The component may also contain a cryptographic hash of the referenced document.
/// Financial items are identified by three parts:
/// (1) the creator of the document,
/// (2) an identification of a dossier, and
/// (3) an identification of a financial item.
/// The two latter identifiers are independent permitting to identify the same item in several lists.
/// The element identification is of schema type ID, it can be referenced by IDREF typed elements (composite=false).
/// </summary>
public partial record QualifiedDocumentInformation1
{
    #nullable enable
    
    /// <summary>
    /// Local identification to be used in IDREFs in this message.
    /// </summary>
    public required IsoID Identification { get; init; } 
    /// <summary>
    /// Party issuing the reference.
    /// </summary>
    public QualifiedPartyIdentification1? Issuer { get; init; } 
    /// <summary>
    /// Unambiguous identifier relative to the issuing party of a list of items.
    /// </summary>
    public IsoMax35Text? ItemListIdentifier { get; init; } 
    /// <summary>
    /// Unambiguous identifier relative to the issuing party of an item (independent of any list).
    /// </summary>
    public IsoMax35Text? ItemIdentifier { get; init; } 
    /// <summary>
    /// Date of document or element. This may be used as a control value to indicate a specific version.
    /// </summary>
    public IsoISODate? Date { get; init; } 
    /// <summary>
    /// Identification of the version of the document or element. This may be used as a control value to indicate a specific version.
    /// </summary>
    public IsoMax6Text? Version { get; init; } 
    /// <summary>
    /// If true, document is in its original form, otherwise it is a scanned version.
    /// </summary>
    public required IsoYesNoIndicator ElectronicOriginal { get; init; } 
    /// <summary>
    /// Cryptographic hash of the document.
    /// </summary>
    public IReadOnlyCollection<AlgorithmAndDigest1> Digest { get; init; } = [];
    /// <summary>
    /// Specifies the type of the document, for example commercial invoice.
    /// </summary>
    public ExternalDocumentType1Code? DocumentType { get; init; } 
    /// <summary>
    /// URL (Uniform Resource Locator) where the document can be found.
    /// </summary>
    public IsoMax2048Text? URL { get; init; } 
    /// <summary>
    /// Attached file for this document. The file must be in a self-describing format.
    /// </summary>
    public BinaryFile1? AttachedFile { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}
