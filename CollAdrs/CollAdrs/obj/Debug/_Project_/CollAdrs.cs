using CollAdrs_Windows_Form1 = CollAdrs.Windows_Form1;

using CollAdrs_Automation1 = CollAdrs.Automation1;

using CollAdrs_Web_Application1 = CollAdrs.Web_Application1;

using System;

namespace CollAdrs.Project
{
// Project-8D5F932F7DFC1E4
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8D5F932F7DFC1E4")]
[OpenSpan.Design.DeploymentVersionAttribute("1.0")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class CollAdrs : OpenSpan.Runtime.RuntimeProject
{
	
	public CollAdrs() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CollAdrs_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public CollAdrs(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CollAdrs_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public CollAdrs(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CollAdrs_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public CollAdrs(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CollAdrs_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private CollAdrs(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.CollAdrs_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void CollAdrs_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8D5F932F7DFC1E4");
		this.mVersion = new System.Version("8.0.1096.0");
		this.mDeploymentVersion = "1.0";
		this.mTransformationVersion = new System.Version("8.0.1026.0");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// DesignForm-8D5F933376DDB37
	public CollAdrs_Windows_Form1 Windows_Form1
	{
		get
		{
			return ((CollAdrs_Windows_Form1)(this["Windows_Form1"]));
		}
	}
	
	// Automator-8D5F933931DF79B
	public CollAdrs_Automation1 Automation1
	{
		get
		{
			return ((CollAdrs_Automation1)(this["Automation1"]));
		}
	}
	
	// WebAdapter-8D5F93350FFB532
	public CollAdrs_Web_Application1 Web_Application1
	{
		get
		{
			return ((CollAdrs_Web_Application1)(this["Web_Application1"]));
		}
	}
}

}

