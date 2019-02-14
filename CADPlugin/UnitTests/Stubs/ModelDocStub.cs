using System;
using SldWorks;

namespace UnitTests.Stubs
{
    /// <summary>
    /// Заглушка для того, чтобы просто получить объект IModelDoc2 без создания сессии SolidWorks
    /// </summary>
    internal class ModelDocStub : IModelDoc2
    {
        public ModelDocStub()
        {

        }
        
        #region Implementation

        public void FeatureFillet(double R1, bool Propagate, bool Ftyp, bool VarRadTyp, int OverflowType)
        {
            throw new NotImplementedException();
        }

        public void GridOptions(bool DispGrid, double GridSpacing, bool Snap, bool DotStyle, short NMajor, short NMinor,
            bool Align2edge, bool AngleSnap, double AngleUnit, bool MinorAuto)
        {
            throw new NotImplementedException();
        }

        public void SetUnits(short UType, short FractBase, short FractDenom, short SigDigits, bool RoundToFraction)
        {
            throw new NotImplementedException();
        }

        public void LBDownAt(int Flags, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void LBUpAt(int Flags, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void DragTo(int Flags, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void SelectAt(int Flags, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void CreateLineVB(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
        {
            throw new NotImplementedException();
        }

        public bool CreateLine(object P1, object P2)
        {
            throw new NotImplementedException();
        }

        public void CreateCenterLineVB(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
        {
            throw new NotImplementedException();
        }

        public bool CreateCenterLine(object P1, object P2)
        {
            throw new NotImplementedException();
        }

        public void CreateArcVB(double P1x, double P1y, double P1z, double P2x, double P2y, double P2z, double P3x, double P3y,
            double P3z, short Dir)
        {
            throw new NotImplementedException();
        }

        public bool CreateArc(object P1, object P2, object P3, short Dir)
        {
            throw new NotImplementedException();
        }

        public void CreateCircleVB(double P1x, double P1y, double P1z, double Radius)
        {
            throw new NotImplementedException();
        }

        public bool CreateCircleByRadius(object P1, double Radius)
        {
            throw new NotImplementedException();
        }

        public object GetLines()
        {
            throw new NotImplementedException();
        }

        public void SketchTrim(int Op, int SelEnd, double X, double Y)
        {
            throw new NotImplementedException();
        }

        public void SketchOffsetEdges(double Val)
        {
            throw new NotImplementedException();
        }

        public void SketchRectangle(double Val1, double Val2, double Z1, double Val3, double Val4, double Z2, bool Val5)
        {
            throw new NotImplementedException();
        }

        public void SketchPoint(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void FeatureCut(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2, bool Ddir1,
            bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2)
        {
            throw new NotImplementedException();
        }

        public void FeatureBoss(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2, bool Ddir1,
            bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2)
        {
            throw new NotImplementedException();
        }

        public void SimpleHole(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2, bool Ddir1,
            bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2)
        {
            throw new NotImplementedException();
        }

        public void FeatureLinearPattern(int Num1, double Spacing1, int Num2, double Spacing2, bool FlipDir1, bool FlipDir2,
            string DName1, string DName2)
        {
            throw new NotImplementedException();
        }

        public void NameView(string VName)
        {
            throw new NotImplementedException();
        }

        public void ShowNamedView(string VName)
        {
            throw new NotImplementedException();
        }

        public void CreatePlaneAtOffset(double Val, bool FlipDir)
        {
            throw new NotImplementedException();
        }

        public void Toolbars(bool M, bool Vw, bool SkMain, bool Sk, bool Feat, bool Constr, bool Macro)
        {
            throw new NotImplementedException();
        }

        public void CreatePlaneAtAngle(double Val, bool FlipDir)
        {
            throw new NotImplementedException();
        }

        public void SetParamValue(double Val)
        {
            throw new NotImplementedException();
        }

        public void AddRelation(string RelStr)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllRelations()
        {
            throw new NotImplementedException();
        }

        public void HoleWizard(double Depth, short EndType, bool Flip, bool Dir, int HType, double D1, double D2, double D3, double D4,
            double D5, double D6, double D7, double D8, double D9, double D10, double D11, double D12)
        {
            throw new NotImplementedException();
        }

        public bool SaveAs(string NewName)
        {
            throw new NotImplementedException();
        }

        public void ActivateSelectedFeature()
        {
            throw new NotImplementedException();
        }

        public void SelectByName(int Flags, string IdStr)
        {
            throw new NotImplementedException();
        }

        public void SketchAddConstraints(string IdStr)
        {
            throw new NotImplementedException();
        }

        public void SketchConstraintsDel(int ConstrInd, string IdStr)
        {
            throw new NotImplementedException();
        }

        public void SketchConstraintsDelAll()
        {
            throw new NotImplementedException();
        }

        public void Lock()
        {
            throw new NotImplementedException();
        }

        public void UnLock()
        {
            throw new NotImplementedException();
        }

        public void InsertFeatureShell(double Thickness, bool Outward)
        {
            throw new NotImplementedException();
        }

        public void SketchFillet(double Rad)
        {
            throw new NotImplementedException();
        }

        public void FeatureChamfer(double Width, double Angle, bool Flip)
        {
            throw new NotImplementedException();
        }

        public void InsertMfDraft(double Angle, bool FlipDir, bool IsEdgeDraft, int PropType)
        {
            throw new NotImplementedException();
        }

        public void ParentChildRelationship()
        {
            throw new NotImplementedException();
        }

        public void SketchSpline(int MorePts, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void SelectSketchPoint(double X, double Y, int Incidence)
        {
            throw new NotImplementedException();
        }

        public void SelectSketchLine(double X0, double Y0, int Inc0, double X1, double Y1, int Inc1)
        {
            throw new NotImplementedException();
        }

        public void SelectSketchArc(double X0, double Y0, int Inc0, double X1, double Y1, int Inc1, double XC, double YC, int IncC,
            int RotDir)
        {
            throw new NotImplementedException();
        }

        public void SelectSketchSpline(int Size, double X0, double Y0, int Inc0, double X1, double Y1, int Inc1, double XC, double YC,
            int IncC)
        {
            throw new NotImplementedException();
        }

        public bool CreateTangentArc(double P1x, double P1y, double P1z, double P2x, double P2y, double P2z)
        {
            throw new NotImplementedException();
        }

        public bool Create3PointArc(double P1x, double P1y, double P1z, double P2x, double P2y, double P2z, double P3x, double P3y,
            double P3z)
        {
            throw new NotImplementedException();
        }

        public bool CreateArcByCenter(double P1x, double P1y, double P1z, double P2x, double P2y, double P2z, double P3x, double P3y,
            double P3z)
        {
            throw new NotImplementedException();
        }

        public bool CreateCircle(double P1x, double P1y, double P1z, double P2x, double P2y, double P2z)
        {
            throw new NotImplementedException();
        }

        public bool AddDimension(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public bool AddHorizontalDimension(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public bool AddVerticalDimension(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public bool SelectSketchItem(int SelOpt, string Name, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void ClearSelection()
        {
            throw new NotImplementedException();
        }

        public void Select(string SelID, string SelParams, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void AndSelect(string SelID, string SelParams, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public bool CreatePoint(double PointX, double PointY, double PointZ)
        {
            throw new NotImplementedException();
        }

        public bool CreateLineDB(double Sx, double Sy, double Sz, double Ex, double Ey, double Ez)
        {
            throw new NotImplementedException();
        }

        public bool CreateArcDB(double X1, double Y1, double Z1, double X2, double Y2, double Z2, double X3, double Y3, double Z3,
            short Dir)
        {
            throw new NotImplementedException();
        }

        public bool CreateCircleDB(double Cx, double Cy, double Cz, double Radius)
        {
            throw new NotImplementedException();
        }

        public bool CreatePointDB(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public string GetTitle()
        {
            throw new NotImplementedException();
        }

        public string GetPathName()
        {
            throw new NotImplementedException();
        }

        public int GetType()
        {
            throw new NotImplementedException();
        }

        public void InsertObject()
        {
            throw new NotImplementedException();
        }

        public void EditClearAll()
        {
            throw new NotImplementedException();
        }

        public void EditCopy()
        {
            throw new NotImplementedException();
        }

        public void EditCut()
        {
            throw new NotImplementedException();
        }

        public void ObjectDisplayContent()
        {
            throw new NotImplementedException();
        }

        public void ObjectDisplayAsIcon()
        {
            throw new NotImplementedException();
        }

        public void ObjectResetsize()
        {
            throw new NotImplementedException();
        }

        public void WindowRedraw()
        {
            throw new NotImplementedException();
        }

        public void Dummy3()
        {
            throw new NotImplementedException();
        }

        public void SetPickMode()
        {
            throw new NotImplementedException();
        }

        public void ViewRotateminusx()
        {
            throw new NotImplementedException();
        }

        public void ViewRotateminusy()
        {
            throw new NotImplementedException();
        }

        public void ViewRotateminusz()
        {
            throw new NotImplementedException();
        }

        public void ViewRotateplusx()
        {
            throw new NotImplementedException();
        }

        public void ViewRotateplusy()
        {
            throw new NotImplementedException();
        }

        public void ViewRotateplusz()
        {
            throw new NotImplementedException();
        }

        public void ViewTranslateminusx()
        {
            throw new NotImplementedException();
        }

        public void ViewTranslateminusy()
        {
            throw new NotImplementedException();
        }

        public void ViewTranslateplusx()
        {
            throw new NotImplementedException();
        }

        public void ViewTranslateplusy()
        {
            throw new NotImplementedException();
        }

        public void ViewRotXMinusNinety()
        {
            throw new NotImplementedException();
        }

        public void ViewRotYMinusNinety()
        {
            throw new NotImplementedException();
        }

        public void ViewRotYPlusNinety()
        {
            throw new NotImplementedException();
        }

        public void ViewZoomin()
        {
            throw new NotImplementedException();
        }

        public void ViewZoomout()
        {
            throw new NotImplementedException();
        }

        public void ViewDisplayHiddenremoved()
        {
            throw new NotImplementedException();
        }

        public void ViewDisplayWireframe()
        {
            throw new NotImplementedException();
        }

        public void ViewDisplayShaded()
        {
            throw new NotImplementedException();
        }

        public void ViewRwShading()
        {
            throw new NotImplementedException();
        }

        public void ViewOglShading()
        {
            throw new NotImplementedException();
        }

        public void ViewZoomtofit()
        {
            throw new NotImplementedException();
        }

        public void ViewRotate()
        {
            throw new NotImplementedException();
        }

        public void ViewTranslate()
        {
            throw new NotImplementedException();
        }

        public void ViewZoomto()
        {
            throw new NotImplementedException();
        }

        public void ViewDisplayHiddengreyed()
        {
            throw new NotImplementedException();
        }

        public void ViewDisplayFaceted()
        {
            throw new NotImplementedException();
        }

        public void ViewConstraint()
        {
            throw new NotImplementedException();
        }

        public void UserFavors()
        {
            throw new NotImplementedException();
        }

        public void FeatureCirPattern(int Num, double Spacing, bool FlipDir, string DName)
        {
            throw new NotImplementedException();
        }

        public void EditSketch()
        {
            throw new NotImplementedException();
        }

        public void FeatEdit()
        {
            throw new NotImplementedException();
        }

        public void FeatEditDef()
        {
            throw new NotImplementedException();
        }

        public void InsertPoint()
        {
            throw new NotImplementedException();
        }

        public void InsertFamilyTableNew()
        {
            throw new NotImplementedException();
        }

        public void Dummy1()
        {
            throw new NotImplementedException();
        }

        public void InsertFamilyTableEdit()
        {
            throw new NotImplementedException();
        }

        public void Dummy2()
        {
            throw new NotImplementedException();
        }

        public void ToolsMacro()
        {
            throw new NotImplementedException();
        }

        public void ToolsGrid()
        {
            throw new NotImplementedException();
        }

        public void SketchCenterline()
        {
            throw new NotImplementedException();
        }

        public void SketchAlign()
        {
            throw new NotImplementedException();
        }

        public void SketchArc()
        {
            throw new NotImplementedException();
        }

        public void SketchTangentArc()
        {
            throw new NotImplementedException();
        }

        public void SketchCircle()
        {
            throw new NotImplementedException();
        }

        public void SketchUndo()
        {
            throw new NotImplementedException();
        }

        public void UserPreferences()
        {
            throw new NotImplementedException();
        }

        public void Lights()
        {
            throw new NotImplementedException();
        }

        public void SketchConstrainCoincident()
        {
            throw new NotImplementedException();
        }

        public void SketchConstrainConcentric()
        {
            throw new NotImplementedException();
        }

        public void SketchConstrainPerp()
        {
            throw new NotImplementedException();
        }

        public void SketchConstrainTangent()
        {
            throw new NotImplementedException();
        }

        public void SketchConstrainParallel()
        {
            throw new NotImplementedException();
        }

        public void SketchUseEdge()
        {
            throw new NotImplementedException();
        }

        public void SketchUseEdgeCtrline()
        {
            throw new NotImplementedException();
        }

        public void SketchMirror()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void ViewDispRefaxes()
        {
            throw new NotImplementedException();
        }

        public void ViewDispRefplanes()
        {
            throw new NotImplementedException();
        }

        public void InsertSketch()
        {
            throw new NotImplementedException();
        }

        public void InsertProtrusionSwept(bool Propagate, bool Alignment, bool KeepNormalConstant)
        {
            throw new NotImplementedException();
        }

        public void InsertProtrusionBlend(bool Closed)
        {
            throw new NotImplementedException();
        }

        public void ToolsMassProps()
        {
            throw new NotImplementedException();
        }

        public void PropertySheet()
        {
            throw new NotImplementedException();
        }

        public void BlankRefGeom()
        {
            throw new NotImplementedException();
        }

        public void UnBlankRefGeom()
        {
            throw new NotImplementedException();
        }

        public void EditDelete()
        {
            throw new NotImplementedException();
        }

        public void InsertProjectedSketch()
        {
            throw new NotImplementedException();
        }

        public bool CreatePlaneFixed(object P1, object P2, object P3, bool UseGlobal)
        {
            throw new NotImplementedException();
        }

        public void Dummy5()
        {
            throw new NotImplementedException();
        }

        public void Dummy6()
        {
            throw new NotImplementedException();
        }

        public void DebugCheckBody()
        {
            throw new NotImplementedException();
        }

        public void Dummy8()
        {
            throw new NotImplementedException();
        }

        public void DimPreferences()
        {
            throw new NotImplementedException();
        }

        public void UnblankSketch()
        {
            throw new NotImplementedException();
        }

        public void EditSketchOrSingleSketchFeature()
        {
            throw new NotImplementedException();
        }

        public void DebugCheckIgesGeom()
        {
            throw new NotImplementedException();
        }

        public void BlankSketch()
        {
            throw new NotImplementedException();
        }

        public double GetDefaultTextHeight()
        {
            throw new NotImplementedException();
        }

        public bool IsActive(string CompStr)
        {
            throw new NotImplementedException();
        }

        public bool CreateEllipse(object Center, object Major, object Minor)
        {
            throw new NotImplementedException();
        }

        public bool CreateEllipseVB(double CenterX, double CenterY, double CenterZ, double MajorX, double MajorY, double MajorZ,
            double MinorX, double MinorY, double MinorZ)
        {
            throw new NotImplementedException();
        }

        public bool CreateEllipticalArcByCenter(object Center, object Major, object Minor, object Start, object End)
        {
            throw new NotImplementedException();
        }

        public bool CreateEllipticalArcByCenterVB(double CenterX, double CenterY, double CenterZ, double MajorX, double MajorY,
            double MajorZ, double MinorX, double MinorY, double MinorZ, double StartX, double StartY, double StartZ,
            double EndX, double EndY, double EndZ)
        {
            throw new NotImplementedException();
        }

        public object GetActiveSketch()
        {
            throw new NotImplementedException();
        }

        public Sketch IGetActiveSketch()
        {
            throw new NotImplementedException();
        }

        public int GetTessellationQuality()
        {
            throw new NotImplementedException();
        }

        public void SetTessellationQuality(int QualityNum)
        {
            throw new NotImplementedException();
        }

        public object Parameter(string StringIn)
        {
            throw new NotImplementedException();
        }

        public Dimension IParameter(string StringIn)
        {
            throw new NotImplementedException();
        }

        public bool SelectByID(string SelID, string SelParams, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public bool AndSelectByID(string SelID, string SelParams, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void Insert3DSketch()
        {
            throw new NotImplementedException();
        }

        public string GetLightSourceName(int ID)
        {
            throw new NotImplementedException();
        }

        public bool AddLightSource(string IdName, int LTyp, string UserName)
        {
            throw new NotImplementedException();
        }

        public int AddLightSourceExtProperty(int ID, object PropertyExtension)
        {
            throw new NotImplementedException();
        }

        public void ResetLightSourceExtProperty(int ID)
        {
            throw new NotImplementedException();
        }

        public void DeleteLightSource(int ID)
        {
            throw new NotImplementedException();
        }

        public object GetLightSourceExtProperty(int ID, int PropertyId)
        {
            throw new NotImplementedException();
        }

        public int AddLightToScene(string LpszNewValue)
        {
            throw new NotImplementedException();
        }

        public int AddSceneExtProperty(object PropertyExtension)
        {
            throw new NotImplementedException();
        }

        public void ResetSceneExtProperty()
        {
            throw new NotImplementedException();
        }

        public object GetSceneExtProperty(int PropertyId)
        {
            throw new NotImplementedException();
        }

        public void FileSummaryInfo()
        {
            throw new NotImplementedException();
        }

        public object GetGridSettings()
        {
            throw new NotImplementedException();
        }

        public void ToolsSketchTranslate()
        {
            throw new NotImplementedException();
        }

        public void ToolsDistance()
        {
            throw new NotImplementedException();
        }

        public void SkToolsAutoConstr()
        {
            throw new NotImplementedException();
        }

        public void ToolsSketchScale()
        {
            throw new NotImplementedException();
        }

        public void Paste()
        {
            throw new NotImplementedException();
        }

        public void ToolsConfiguration()
        {
            throw new NotImplementedException();
        }

        public void EntityProperties()
        {
            throw new NotImplementedException();
        }

        public bool GetArcCentersDisplayed()
        {
            throw new NotImplementedException();
        }

        public void SetArcCentersDisplayed(bool Setting)
        {
            throw new NotImplementedException();
        }

        public void AutoSolveToggle()
        {
            throw new NotImplementedException();
        }

        public void Dummy7()
        {
            throw new NotImplementedException();
        }

        public double IGetLines()
        {
            throw new NotImplementedException();
        }

        public int GetLineCount()
        {
            throw new NotImplementedException();
        }

        public void ICreateEllipse(ref double Center, ref double Major, ref double Minor)
        {
            throw new NotImplementedException();
        }

        public void ICreateEllipticalArcByCenter(ref double Center, ref double Major, ref double Minor, ref double Start,
            ref double End)
        {
            throw new NotImplementedException();
        }

        public void InsertCutSwept(bool Propagate, bool Alignment, bool KeepNormalConstant)
        {
            throw new NotImplementedException();
        }

        public void InsertCutBlend(bool Closed)
        {
            throw new NotImplementedException();
        }

        public void InsertHelix(bool Reversed, bool Clockwised, bool Tapered, bool Outward, int Helixdef, double Height, double Pitch,
            double Revolution, double TaperAngle, double Startangle)
        {
            throw new NotImplementedException();
        }

        public void ICreateLine(ref double P1, ref double P2)
        {
            throw new NotImplementedException();
        }

        public void ICreateCenterLine(ref double P1, ref double P2)
        {
            throw new NotImplementedException();
        }

        public void ICreateArc(ref double P1, ref double P2, ref double P3, short Dir)
        {
            throw new NotImplementedException();
        }

        public void ICreateCircleByRadius(ref double P1, double Radius)
        {
            throw new NotImplementedException();
        }

        public void GraphicsRedraw()
        {
            throw new NotImplementedException();
        }

        public bool GetVisibilityOfConstructPlanes()
        {
            throw new NotImplementedException();
        }

        public bool GetDisplayWhenAdded()
        {
            throw new NotImplementedException();
        }

        public void SetDisplayWhenAdded(bool Setting)
        {
            throw new NotImplementedException();
        }

        public bool GetAddToDB()
        {
            throw new NotImplementedException();
        }

        public void SetAddToDB(bool Setting)
        {
            throw new NotImplementedException();
        }

        public bool DeSelectByID(string SelID, string SelParams, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void PrintDirect()
        {
            throw new NotImplementedException();
        }

        public void PrintPreview()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public void CreatePlaneThru3Points()
        {
            throw new NotImplementedException();
        }

        public void ViewRotXPlusNinety()
        {
            throw new NotImplementedException();
        }

        public object GetUnits()
        {
            throw new NotImplementedException();
        }

        public void SetAngularUnits(short UType, short FractBase, short FractDenom, short SigDigits)
        {
            throw new NotImplementedException();
        }

        public object GetAngularUnits()
        {
            throw new NotImplementedException();
        }

        public short IGetUnits()
        {
            throw new NotImplementedException();
        }

        public void ISetAngularUnits(short UType, short FractBase, short FractDenom, short SigDigits)
        {
            throw new NotImplementedException();
        }

        public short IGetAngularUnits()
        {
            throw new NotImplementedException();
        }

        public void ShowConfiguration(string ConfigurationName)
        {
            throw new NotImplementedException();
        }

        public void ResetConfiguration()
        {
            throw new NotImplementedException();
        }

        public void AddConfiguration(string Name, string Comment, string AlternateName, bool SuppressByDefault, bool HideByDefault,
            bool MinFeatureManager, bool InheritProperties, uint Flags)
        {
            throw new NotImplementedException();
        }

        public void DeleteConfiguration(string ConfigurationName)
        {
            throw new NotImplementedException();
        }

        public void EditConfiguration(string Name, string NewName, string Comment, string AlternateName, bool SuppressByDefault,
            bool HideByDefault, bool MinFeatureManager, bool InheritProperties, uint Flags)
        {
            throw new NotImplementedException();
        }

        public void CreatePlanePerCurveAndPassPoint(bool OrigAtCurve)
        {
            throw new NotImplementedException();
        }

        public object CreateFeatureMgrView(ref int Bitmap)
        {
            throw new NotImplementedException();
        }

        public bool AddFeatureMgrView(ref int Bitmap, ref int AppView)
        {
            throw new NotImplementedException();
        }

        public object GetStandardViewRotation(int ViewId)
        {
            throw new NotImplementedException();
        }

        public double IGetStandardViewRotation(int ViewId)
        {
            throw new NotImplementedException();
        }

        public void FeatureExtruRefSurface(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2)
        {
            throw new NotImplementedException();
        }

        public object IGet3rdPartyStorage(string StringIn, bool IsStoring)
        {
            throw new NotImplementedException();
        }

        public void DeleteFeatureMgrView(ref int AppView)
        {
            throw new NotImplementedException();
        }

        public object GetMassProperties()
        {
            throw new NotImplementedException();
        }

        public bool IGetMassProperties(ref double MPropsData)
        {
            throw new NotImplementedException();
        }

        public int GetLightSourceCount()
        {
            throw new NotImplementedException();
        }

        public int GetLightSourceIdFromName(string LightName)
        {
            throw new NotImplementedException();
        }

        public void SetNextSelectionGroupId(int ID)
        {
            throw new NotImplementedException();
        }

        public void ISetNextSelectionGroupId(int ID)
        {
            throw new NotImplementedException();
        }

        public object InsertMidSurfaceExt(double Placement, bool KnitFlag)
        {
            throw new NotImplementedException();
        }

        public MidSurface2 IInsertMidSurfaceExt(double Placement, bool KnitFlag)
        {
            throw new NotImplementedException();
        }

        public void ICreatePlaneFixed(ref double P1, ref double P2, ref double P3, bool UseGlobal)
        {
            throw new NotImplementedException();
        }

        public bool SelectByMark(string SelID, string SelParams, double X, double Y, double Z, int Mark)
        {
            throw new NotImplementedException();
        }

        public bool AndSelectByMark(string SelID, string SelParams, double X, double Y, double Z, int Mark)
        {
            throw new NotImplementedException();
        }

        public object GetDependencies(int Traverseflag, int Searchflag)
        {
            throw new NotImplementedException();
        }

        public string IGetDependencies(int Traverseflag, int Searchflag)
        {
            throw new NotImplementedException();
        }

        public int GetNumDependencies(int Traverseflag, int Searchflag)
        {
            throw new NotImplementedException();
        }

        public int IGetNumDependencies(int Traverseflag, int Searchflag)
        {
            throw new NotImplementedException();
        }

        public object FirstFeature()
        {
            throw new NotImplementedException();
        }

        public Feature IFirstFeature()
        {
            throw new NotImplementedException();
        }

        public void UnderiveSketch()
        {
            throw new NotImplementedException();
        }

        public void DeriveSketch()
        {
            throw new NotImplementedException();
        }

        public bool IsExploded()
        {
            throw new NotImplementedException();
        }

        public bool DeleteSelection(bool ConfirmFlag)
        {
            throw new NotImplementedException();
        }

        public bool DeleteNamedView(string ViewName)
        {
            throw new NotImplementedException();
        }

        public bool SetLightSourceName(int ID, string NewName)
        {
            throw new NotImplementedException();
        }

        public void Insert3DSplineCurve(bool CurveClosed)
        {
            throw new NotImplementedException();
        }

        public bool SetLightSourcePropertyValuesVB(string IdName, int LType, double Diff, int RgbColor, double Dist, double DirX,
            double DirY, double DirZ, double SpotDirX, double SpotDirY, double SpotDirZ, double SpotAngle, double FallOff0,
            double FallOff1, double FallOff2, double Ambient, double Specular, double SpotExponent, bool BDisable)
        {
            throw new NotImplementedException();
        }

        public FeatMgrView ICreateFeatureMgrView(ref int Bitmap)
        {
            throw new NotImplementedException();
        }

        public bool SelectedEdgeProperties(string EdgeName)
        {
            throw new NotImplementedException();
        }

        public bool SelectedFaceProperties(int RgbColor, double Ambient, double Diffuse, double Specular, double Shininess,
            double Transparency, double Emission, bool UsePartProps, string FaceName)
        {
            throw new NotImplementedException();
        }

        public bool SelectedFeatureProperties(int RgbColor, double Ambient, double Diffuse, double Specular, double Shininess,
            double Transparency, double Emission, bool UsePartProps, bool Suppressed, string FeatureName)
        {
            throw new NotImplementedException();
        }

        public void InsertSplitLineSil()
        {
            throw new NotImplementedException();
        }

        public void InsertSplitLineProject(bool IsDirectional, bool FlipDir)
        {
            throw new NotImplementedException();
        }

        public void InsertRib(bool Is2Sided, bool ReverseThicknessDir, double Thickness, int ReferenceEdgeIndex,
            bool ReverseMaterialDir, bool IsDrafted, bool DraftOutward, double DraftAngle)
        {
            throw new NotImplementedException();
        }

        public bool AddRadialDimension(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public bool AddDiameterDimension(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public object GetModelViewNames()
        {
            throw new NotImplementedException();
        }

        public string IGetModelViewNames()
        {
            throw new NotImplementedException();
        }

        public int GetModelViewCount()
        {
            throw new NotImplementedException();
        }

        public double GetUserPreferenceDoubleValue(int UserPreferenceValue)
        {
            throw new NotImplementedException();
        }

        public bool SetUserPreferenceDoubleValue(int UserPreferenceValue, double Value)
        {
            throw new NotImplementedException();
        }

        public void ViewDisplayCurvature()
        {
            throw new NotImplementedException();
        }

        public void Scale()
        {
            throw new NotImplementedException();
        }

        public void AddIns()
        {
            throw new NotImplementedException();
        }

        public bool InsertCurveFile(string FileName)
        {
            throw new NotImplementedException();
        }

        public void InsertCurveFileBegin()
        {
            throw new NotImplementedException();
        }

        public bool InsertCurveFilePoint(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public bool InsertCurveFileEnd()
        {
            throw new NotImplementedException();
        }

        public bool ChangeSketchPlane()
        {
            throw new NotImplementedException();
        }

        public void ViewOrientationUndo()
        {
            throw new NotImplementedException();
        }

        public void PrintOut(int FromPage, int ToPage, int NumCopies, bool Collate, string Printer, double Scale, bool PrintToFile)
        {
            throw new NotImplementedException();
        }

        public void SketchOffsetEntities(double Offset, bool Flip)
        {
            throw new NotImplementedException();
        }

        public void InsertLibraryFeature(string LibFeatPartNameIn)
        {
            throw new NotImplementedException();
        }

        public void SketchModifyTranslate(double StartX, double StartY, double EndX, double EndY)
        {
            throw new NotImplementedException();
        }

        public void SketchModifyRotate(double CenterX, double CenterY, double Angle)
        {
            throw new NotImplementedException();
        }

        public void SketchModifyFlip(int AxisFlag)
        {
            throw new NotImplementedException();
        }

        public bool SketchModifyScale(double ScaleFactor)
        {
            throw new NotImplementedException();
        }

        public object GetActiveConfiguration()
        {
            throw new NotImplementedException();
        }

        public Configuration IGetActiveConfiguration()
        {
            throw new NotImplementedException();
        }

        public bool GetUserPreferenceToggle(int UserPreferenceToggle)
        {
            throw new NotImplementedException();
        }

        public bool SetUserPreferenceToggle(int UserPreferenceValue, bool OnFlag)
        {
            throw new NotImplementedException();
        }

        public void InsertSweepRefSurface(bool Propagate, short TwistCtrlOption, bool KeepTangency, bool ForceNonRational)
        {
            throw new NotImplementedException();
        }

        public void InsertLoftRefSurface(bool Closed, bool KeepTangency, bool ForceNonRational)
        {
            throw new NotImplementedException();
        }

        public void InsertProtrusionSwept2(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency,
            bool ForceNonRational)
        {
            throw new NotImplementedException();
        }

        public void InsertProtrusionBlend2(bool Closed, bool KeepTangency, bool ForceNonRational)
        {
            throw new NotImplementedException();
        }

        public void InsertCutSwept2(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency, bool ForceNonRational)
        {
            throw new NotImplementedException();
        }

        public void InsertCutBlend2(bool Closed, bool KeepTangency, bool ForceNonRational)
        {
            throw new NotImplementedException();
        }

        public bool IsEditingSelf()
        {
            throw new NotImplementedException();
        }

        public void ShowNamedView2(string VName, int ViewId)
        {
            throw new NotImplementedException();
        }

        public void InsertDome(double Height, bool ReverseDir, bool DoEllipticSurface)
        {
            throw new NotImplementedException();
        }

        public int AddPropertyExtension(object PropertyExtension)
        {
            throw new NotImplementedException();
        }

        public object GetPropertyExtension(int ID)
        {
            throw new NotImplementedException();
        }

        public void ResetPropertyExtension()
        {
            throw new NotImplementedException();
        }

        public int GetUpdateStamp()
        {
            throw new NotImplementedException();
        }

        public void ViewZoomTo2(double X1, double Y1, double Z1, double X2, double Y2, double Z2)
        {
            throw new NotImplementedException();
        }

        public void ScreenRotate()
        {
            throw new NotImplementedException();
        }

        public void GraphicsRedraw2()
        {
            throw new NotImplementedException();
        }

        public void InsertCosmeticThread(short Type, double Depth, double Length, string Note)
        {
            throw new NotImplementedException();
        }

        public void HideCosmeticThread()
        {
            throw new NotImplementedException();
        }

        public void ShowCosmeticThread()
        {
            throw new NotImplementedException();
        }

        public void SimpleHole2(double Dia, bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2)
        {
            throw new NotImplementedException();
        }

        public void IRelease3rdPartyStorage(string StringIn)
        {
            throw new NotImplementedException();
        }

        public int FeatureRevolve2(double Angle, bool ReverseDir, double Angle2, int RevType, int Options)
        {
            throw new NotImplementedException();
        }

        public int FeatureRevolveCut2(double Angle, bool ReverseDir, double Angle2, int RevType, int Options)
        {
            throw new NotImplementedException();
        }

        public void SetSaveFlag()
        {
            throw new NotImplementedException();
        }

        public string GetExternalReferenceName()
        {
            throw new NotImplementedException();
        }

        public bool SelectByRay(object DoubleInfoIn, int TypeWanted)
        {
            throw new NotImplementedException();
        }

        public bool ISelectByRay(ref double PointIn, ref double VectorIn, double RadiusIn, int TypeWanted)
        {
            throw new NotImplementedException();
        }

        public void SetSceneBkgDIB(int L_dib)
        {
            throw new NotImplementedException();
        }

        public void InsertBkgImage(string NewName)
        {
            throw new NotImplementedException();
        }

        public void DeleteBkgImage()
        {
            throw new NotImplementedException();
        }

        public void InsertSplinePoint(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void InsertLoftRefSurface2(bool Closed, bool KeepTangency, bool ForceNonRational, double TessToleranceFactor,
            short StartMatchingType, short EndMatchingType)
        {
            throw new NotImplementedException();
        }

        public void InsertProtrusionBlend3(bool Closed, bool KeepTangency, bool ForceNonRational, double TessToleranceFactor,
            short StartMatchingType, short EndMatchingType)
        {
            throw new NotImplementedException();
        }

        public void InsertCutBlend3(bool Closed, bool KeepTangency, bool ForceNonRational, double TessToleranceFactor,
            short StartMatchingType, short EndMatchingType)
        {
            throw new NotImplementedException();
        }

        public void AlignDimensions()
        {
            throw new NotImplementedException();
        }

        public void BreakDimensionAlignment()
        {
            throw new NotImplementedException();
        }

        public void SketchFillet1(double Rad)
        {
            throw new NotImplementedException();
        }

        public void FeatureChamferType(short ChamferType, double Width, double Angle, bool Flip, double OtherDist,
            double VertexChamDist1, double VertexChamDist2, double VertexChamDist3)
        {
            throw new NotImplementedException();
        }

        public void FeatureCutThin(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2, double Thk1,
            double Thk2, double EndThk, int RevThinDir, int CapEnds, bool AddBends, double BendRad)
        {
            throw new NotImplementedException();
        }

        public void FeatureBossThin(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2, double Thk1,
            double Thk2, double EndThk, int RevThinDir, int CapEnds, bool AddBends, double BendRad)
        {
            throw new NotImplementedException();
        }

        public bool InsertDatumTargetSymbol(string Datum1, string Datum2, string Datum3, short AreaStyle, bool AreaOutside,
            double Value1, double Value2, string ValueStr1, string ValueStr2, bool ArrowsSmart, short ArrowStyle,
            short LeaderLineStyle, bool LeaderBent, bool ShowArea, bool ShowSymbol)
        {
            throw new NotImplementedException();
        }

        public bool EditDatumTargetSymbol(string Datum1, string Datum2, string Datum3, short AreaStyle, bool AreaOutside,
            double Value1, double Value2, string ValueStr1, string ValueStr2, bool ArrowsSmart, short ArrowStyle,
            short LeaderLineStyle, bool LeaderBent, bool ShowArea, bool ShowSymbol)
        {
            throw new NotImplementedException();
        }

        public void InsertBOMBalloon()
        {
            throw new NotImplementedException();
        }

        public object FeatureReferenceCurve(int NumOfCurves, object BaseCurves, bool Merge, string FromFileName, out int ErrorCode)
        {
            throw new NotImplementedException();
        }

        public ReferenceCurve IFeatureReferenceCurve(int NumOfCurves, ref Curve BaseCurves, bool Merge, string FromFileName,
            out int ErrorCode)
        {
            throw new NotImplementedException();
        }

        public void FontBold(bool Bold)
        {
            throw new NotImplementedException();
        }

        public void FontItalic(bool Italic)
        {
            throw new NotImplementedException();
        }

        public void FontUnderline(bool Underline)
        {
            throw new NotImplementedException();
        }

        public void FontFace(string Face)
        {
            throw new NotImplementedException();
        }

        public void FontPoints(short Points)
        {
            throw new NotImplementedException();
        }

        public void FontUnits(double Units)
        {
            throw new NotImplementedException();
        }

        public bool SketchSplineByEqnParams(object ParamsIn)
        {
            throw new NotImplementedException();
        }

        public void AlignParallelDimensions()
        {
            throw new NotImplementedException();
        }

        public void SetBlockingState(int StateIn)
        {
            throw new NotImplementedException();
        }

        public void ResetBlockingState()
        {
            throw new NotImplementedException();
        }

        public int GetSceneBkgDIB()
        {
            throw new NotImplementedException();
        }

        public void InsertHatchedFace()
        {
            throw new NotImplementedException();
        }

        public object GetColorTable()
        {
            throw new NotImplementedException();
        }

        public ColorTable IGetColorTable()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepRefSurface2(bool Propagate, short TwistCtrlOption, bool KeepTangency, bool ForceNonRational,
            short StartMatchingType, short EndMatchingType)
        {
            throw new NotImplementedException();
        }

        public void InsertProtrusionSwept3(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency,
            bool ForceNonRational, short StartMatchingType, short EndMatchingType)
        {
            throw new NotImplementedException();
        }

        public void InsertCutSwept3(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency, bool ForceNonRational,
            short StartMatchingType, short EndMatchingType)
        {
            throw new NotImplementedException();
        }

        public bool IsOpenedViewOnly()
        {
            throw new NotImplementedException();
        }

        public bool IsOpenedReadOnly()
        {
            throw new NotImplementedException();
        }

        public void ViewZoomToSelection()
        {
            throw new NotImplementedException();
        }

        public void FeatureBossThicken(double Thickness, int Direction, int FaceIndex)
        {
            throw new NotImplementedException();
        }

        public void FeatureCutThicken(double Thickness, int Direction, int FaceIndex)
        {
            throw new NotImplementedException();
        }

        public bool InsertAxis()
        {
            throw new NotImplementedException();
        }

        public void EditUndo(uint NSteps)
        {
            throw new NotImplementedException();
        }

        public void SelectMidpoint()
        {
            throw new NotImplementedException();
        }

        public int ISketchSplineByEqnParams(ref int PropArray, ref double KnotsArray, ref double CntrlPntCoordArray)
        {
            throw new NotImplementedException();
        }

        public object VersionHistory()
        {
            throw new NotImplementedException();
        }

        public string IVersionHistory()
        {
            throw new NotImplementedException();
        }

        public int IGetVersionHistoryCount()
        {
            throw new NotImplementedException();
        }

        public void Rebuild(int Options)
        {
            throw new NotImplementedException();
        }

        public void InsertFeatureShellAddThickness(double Thickness)
        {
            throw new NotImplementedException();
        }

        public void InsertOffsetSurface(double Thickness, bool Reverse)
        {
            throw new NotImplementedException();
        }

        public void SimplifySpline(double ToleranceIn)
        {
            throw new NotImplementedException();
        }

        public int GetCustomInfoCount()
        {
            throw new NotImplementedException();
        }

        public string GetCustomInfoType(string FieldName)
        {
            throw new NotImplementedException();
        }

        public object GetCustomInfoNames()
        {
            throw new NotImplementedException();
        }

        public string IGetCustomInfoNames()
        {
            throw new NotImplementedException();
        }

        public bool AddCustomInfo(string FieldName, string FieldType, string FieldValue)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomInfo(string FieldName)
        {
            throw new NotImplementedException();
        }

        public void PrintOut2(int FromPage, int ToPage, int NumCopies, bool Collate, string Printer, double Scale, bool PrintToFile,
            string PtfName)
        {
            throw new NotImplementedException();
        }

        public bool SetReadOnlyState(bool SetReadOnly)
        {
            throw new NotImplementedException();
        }

        public bool InsertFamilyTableOpen(string FileName)
        {
            throw new NotImplementedException();
        }

        public bool MultiSelectByRay(object DoubleInfoIn, int TypeWanted, bool Append)
        {
            throw new NotImplementedException();
        }

        public bool IMultiSelectByRay(ref double PointIn, ref double VectorIn, double RadiusIn, int TypeWanted, bool Append)
        {
            throw new NotImplementedException();
        }

        public void InsertNewNote3(string UpperText, bool NoLeader, bool BentLeader, short ArrowStyle, short LeaderSide, double Angle,
            short BalloonStyle, short BalloonFit, bool SmartArrow)
        {
            throw new NotImplementedException();
        }

        public void InsertWeldSymbol2(string Dim1, string Symbol, string Dim2, bool Symmetric, bool FieldWeld, bool ShowOtherSide,
            bool DashOnTop, bool Peripheral, bool HasProcess, string ProcessValue)
        {
            throw new NotImplementedException();
        }

        public bool InsertSurfaceFinishSymbol2(int SymType, int LeaderType, double LocX, double LocY, double LocZ, int LaySymbol,
            int ArrowType, string MachAllowance, string OtherVals, string ProdMethod, string SampleLen, string MaxRoughness,
            string MinRoughness, string RoughnessSpacing)
        {
            throw new NotImplementedException();
        }

        public int SaveSilent()
        {
            throw new NotImplementedException();
        }

        public int SaveAsSilent(string NewName, bool SaveAsCopy)
        {
            throw new NotImplementedException();
        }

        public bool AddCustomInfo2(string FieldName, int FieldType, string FieldValue)
        {
            throw new NotImplementedException();
        }

        public int GetCustomInfoType2(string FieldName)
        {
            throw new NotImplementedException();
        }

        public bool InsertRefPoint()
        {
            throw new NotImplementedException();
        }

        public int FeatureFillet2(double R1, bool Propagate, bool Ftyp, bool VarRadTyp, int OverflowType, int NRadii, object Radii)
        {
            throw new NotImplementedException();
        }

        public int IFeatureFillet2(double R1, bool Propagate, bool Ftyp, bool VarRadTyp, int OverflowType, int NRadii,
            ref double Radii)
        {
            throw new NotImplementedException();
        }

        public object GetFirstAnnotation()
        {
            throw new NotImplementedException();
        }

        public Annotation IGetFirstAnnotation()
        {
            throw new NotImplementedException();
        }

        public bool InsertCoordinateSystem(bool XFlippedIn, bool YFlippedIn, bool ZFlippedIn)
        {
            throw new NotImplementedException();
        }

        public bool GetToolbarVisibility(int Toolbar)
        {
            throw new NotImplementedException();
        }

        public void SetToolbarVisibility(int Toolbar, bool Visibility)
        {
            throw new NotImplementedException();
        }

        public void ViewDispCoordinateSystems()
        {
            throw new NotImplementedException();
        }

        public void ViewDispTempRefaxes()
        {
            throw new NotImplementedException();
        }

        public void ViewDispRefPoints()
        {
            throw new NotImplementedException();
        }

        public void ViewDispOrigins()
        {
            throw new NotImplementedException();
        }

        public object GetCoordinateSystemXformByName(string NameIn)
        {
            throw new NotImplementedException();
        }

        public double IGetCoordinateSystemXformByName(string NameIn)
        {
            throw new NotImplementedException();
        }

        public string GetCurrentCoordinateSystemName()
        {
            throw new NotImplementedException();
        }

        public EnumModelViews EnumModelViews()
        {
            throw new NotImplementedException();
        }

        public bool InsertCompositeCurve()
        {
            throw new NotImplementedException();
        }

        public void SketchParabola(double Val1, double Val2, double Z1, double Val3, double Val4, double Z2, double Val5, double Val6,
            double Z3, double Val7, double Val8, double Z4)
        {
            throw new NotImplementedException();
        }

        public void InsertRadiateSurface(double Distance, bool FlipDir, bool TangentPropagate)
        {
            throw new NotImplementedException();
        }

        public void InsertSewRefSurface()
        {
            throw new NotImplementedException();
        }

        public int InsertShape(int PressureOn, int TangentsOn, double PressureGain, double TangentGain, double CurveSpringGain,
            double Alpha, double Beta, double Gamma, double Delta, int Degree, int Split, int Tuning)
        {
            throw new NotImplementedException();
        }

        public void InsertMfDraft2(double Angle, bool FlipDir, bool IsEdgeDraft, int PropType, bool StepDraft)
        {
            throw new NotImplementedException();
        }

        public int GetConfigurationCount()
        {
            throw new NotImplementedException();
        }

        public object GetConfigurationNames()
        {
            throw new NotImplementedException();
        }

        public string IGetConfigurationNames(ref int Count)
        {
            throw new NotImplementedException();
        }

        public void FeatureCut2(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2, bool Ddir1,
            bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2, int KeepPieceIndex)
        {
            throw new NotImplementedException();
        }

        public void InsertCutSurface(bool Flip, int KeepPieceIndex)
        {
            throw new NotImplementedException();
        }

        public object GetDetailingDefaults()
        {
            throw new NotImplementedException();
        }

        public DetailingDefaults IGetDetailingDefaults()
        {
            throw new NotImplementedException();
        }

        public int ListExternalFileReferencesCount(bool UseSearchRules)
        {
            throw new NotImplementedException();
        }

        public object ListExternalFileReferences(bool UseSearchRules)
        {
            throw new NotImplementedException();
        }

        public string IListExternalFileReferences(bool UseSearchRules, int NumRefs)
        {
            throw new NotImplementedException();
        }

        public bool SketchSplineByEqnParams2(object ParamsIn)
        {
            throw new NotImplementedException();
        }

        public object GetFirstModelView()
        {
            throw new NotImplementedException();
        }

        public ModelView IGetFirstModelView()
        {
            throw new NotImplementedException();
        }

        public bool InsertPlanarRefSurface()
        {
            throw new NotImplementedException();
        }

        public object GetNext()
        {
            throw new NotImplementedException();
        }

        public bool GetSaveFlag()
        {
            throw new NotImplementedException();
        }

        public bool AddCustomInfo3(string Configuration, string FieldName, int FieldType, string FieldValue)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomInfo2(string Configuration, string FieldName)
        {
            throw new NotImplementedException();
        }

        public int GetCustomInfoCount2(string Configuration)
        {
            throw new NotImplementedException();
        }

        public object GetCustomInfoNames2(string Configuration)
        {
            throw new NotImplementedException();
        }

        public string IGetCustomInfoNames2(string Configuration)
        {
            throw new NotImplementedException();
        }

        public int GetCustomInfoType3(string Configuration, string FieldName)
        {
            throw new NotImplementedException();
        }

        public bool GetConsiderLeadersAsLines()
        {
            throw new NotImplementedException();
        }

        public bool SetConsiderLeadersAsLines(bool LeadersAsLines)
        {
            throw new NotImplementedException();
        }

        public void InsertRevolvedRefSurface(double Angle, bool ReverseDir, double Angle2, int RevType)
        {
            throw new NotImplementedException();
        }

        public int GetBendState()
        {
            throw new NotImplementedException();
        }

        public int SetBendState(int BendState)
        {
            throw new NotImplementedException();
        }

        public void ClearUndoList()
        {
            throw new NotImplementedException();
        }

        public int GetFeatureManagerWidth()
        {
            throw new NotImplementedException();
        }

        public int SetFeatureManagerWidth(int Width)
        {
            throw new NotImplementedException();
        }

        public object InsertProjectedSketch2(int Reverse)
        {
            throw new NotImplementedException();
        }

        public Feature IInsertProjectedSketch2(int Reverse)
        {
            throw new NotImplementedException();
        }

        public int GetFeatureCount()
        {
            throw new NotImplementedException();
        }

        public object FeatureByPositionReverse(int Num)
        {
            throw new NotImplementedException();
        }

        public Feature IFeatureByPositionReverse(int Num)
        {
            throw new NotImplementedException();
        }

        public int RayIntersections(object BodiesIn, object BasePointsIn, object VectorsIn, int Options, double HitRadius,
            double Offset)
        {
            throw new NotImplementedException();
        }

        public int IRayIntersections(ref Body2 BodiesIn, int NumBodies, ref double BasePointsIn, ref double VectorsIn, int NumRays,
            int Options, double HitRadius, double Offset)
        {
            throw new NotImplementedException();
        }

        public object GetRayIntersectionsPoints()
        {
            throw new NotImplementedException();
        }

        public double IGetRayIntersectionsPoints()
        {
            throw new NotImplementedException();
        }

        public object GetRayIntersectionsTopology()
        {
            throw new NotImplementedException();
        }

        public object IGetRayIntersectionsTopology()
        {
            throw new NotImplementedException();
        }

        public void EditSeedFeat()
        {
            throw new NotImplementedException();
        }

        public bool EditSuppress()
        {
            throw new NotImplementedException();
        }

        public bool EditUnsuppress()
        {
            throw new NotImplementedException();
        }

        public bool EditUnsuppressDependent()
        {
            throw new NotImplementedException();
        }

        public bool EditRollback()
        {
            throw new NotImplementedException();
        }

        public int Save2(bool Silent)
        {
            throw new NotImplementedException();
        }

        public int SaveAs2(string NewName, int SaveAsVersion, bool SaveAsCopy, bool Silent)
        {
            throw new NotImplementedException();
        }

        public void SetPopupMenuMode(int ModeIn)
        {
            throw new NotImplementedException();
        }

        public int GetPopupMenuMode()
        {
            throw new NotImplementedException();
        }

        public void CloseFamilyTable()
        {
            throw new NotImplementedException();
        }

        public void CreatePlaneAtSurface(int InterIndex, bool ProjOpt, bool ReverseDir, bool NormalPlane, double Angle)
        {
            throw new NotImplementedException();
        }

        public void SketchOffset(double Offset, bool ContourMode)
        {
            throw new NotImplementedException();
        }

        public bool CreateLinearSketchStepAndRepeat(int NumX, int NumY, double SpacingX, double SpacingY, double AngleX, double AngleY,
            string DeleteInstances)
        {
            throw new NotImplementedException();
        }

        public bool SetAmbientLightProperties(string Name, double Ambient, double Diffuse, double Specular, int Colour, bool Enabled,
            bool Fixed)
        {
            throw new NotImplementedException();
        }

        public bool GetAmbientLightProperties(string Name, ref double Ambient, ref double Diffuse, ref double Specular, ref int Colour,
            ref bool Enabled, ref bool Fixed)
        {
            throw new NotImplementedException();
        }

        public bool SetPointLightProperties(string Name, double Ambient, double Diffuse, double Specular, int Colour, bool Enabled,
            bool Fixed, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public bool GetPointLightProperties(string Name, ref double Ambient, ref double Diffuse, ref double Specular, ref int Colour,
            ref bool Enabled, ref bool Fixed, ref double X, ref double Y, ref double Z)
        {
            throw new NotImplementedException();
        }

        public bool SetDirectionLightProperties(string Name, double Ambient, double Diffuse, double Specular, int Colour, bool Enabled,
            bool Fixed, double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public bool GetDirectionLightProperties(string Name, ref double Ambient, ref double Diffuse, ref double Specular,
            ref int Colour, ref bool Enabled, ref bool Fixed, ref double X, ref double Y, ref double Z)
        {
            throw new NotImplementedException();
        }

        public bool SetSpotlightProperties(string Name, double Ambient, double Diffuse, double Specular, int Colour, bool Enabled,
            bool Fixed, double Posx, double Posy, double Posz, double Targetx, double Targety, double Targetz,
            double ConeAngle)
        {
            throw new NotImplementedException();
        }

        public bool GetSpotlightProperties(string Name, ref double Ambient, ref double Diffuse, ref double Specular, ref int Colour,
            ref bool Enabled, ref bool Fixed, ref double X, ref double Y, ref double Z, ref double Targetx, ref double Targety,
            ref double Targetz, ref double ConeAngle)
        {
            throw new NotImplementedException();
        }

        public void SplitOpenSegment(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public void AutoInferToggle()
        {
            throw new NotImplementedException();
        }

        public void SketchRectangleAtAnyAngle(double Val1, double Val2, double Z1, double Val3, double Val4, double Z2, double Val3x,
            double Val3y, double Z3, bool Val5)
        {
            throw new NotImplementedException();
        }

        public bool CreateCircularSketchStepAndRepeat(double ArcRadius, double ArcAngle, int PatternNum, double PatternSpacing,
            bool PatternRotate, string DeleteInstances)
        {
            throw new NotImplementedException();
        }

        public void SplitClosedSegment(double X0, double Y0, double Z0, double X1, double Y1, double Z1)
        {
            throw new NotImplementedException();
        }

        public bool IsLightLockedToModel(int LightId)
        {
            throw new NotImplementedException();
        }

        public bool LockLightToModel(int LightId, bool Fix)
        {
            throw new NotImplementedException();
        }

        public int FeatureFillet3(double R1, bool Propagate, int Ftyp, bool VarRadTyp, int OverflowType, int NRadii, object Radii,
            bool UseHelpPoint, bool UseTangentHoldLine)
        {
            throw new NotImplementedException();
        }

        public int IFeatureFillet3(double R1, bool Propagate, int Ftyp, bool VarRadTyp, int OverflowType, int NRadii, ref double Radii,
            bool UseHelpPoint, bool UseTangentHoldLine)
        {
            throw new NotImplementedException();
        }

        public void InsertConnectionPoint()
        {
            throw new NotImplementedException();
        }

        public void InsertRoutePoint()
        {
            throw new NotImplementedException();
        }

        public void FeatureBossThicken2(double Thickness, int Direction, int FaceIndex, bool FillVolume)
        {
            throw new NotImplementedException();
        }

        public void FeatureCutThicken2(double Thickness, int Direction, int FaceIndex, bool FillVolume)
        {
            throw new NotImplementedException();
        }

        public object GetConfigurationByName(string Name)
        {
            throw new NotImplementedException();
        }

        public Configuration IGetConfigurationByName(string Name)
        {
            throw new NotImplementedException();
        }

        public object CreatePoint2(double PointX, double PointY, double PointZ)
        {
            throw new NotImplementedException();
        }

        public SketchPoint ICreatePoint2(double PointX, double PointY, double PointZ)
        {
            throw new NotImplementedException();
        }

        public object CreateLine2(double P1x, double P1y, double P1z, double P2x, double P2y, double P2z)
        {
            throw new NotImplementedException();
        }

        public SketchSegment ICreateLine2(double P1x, double P1y, double P1z, double P2x, double P2y, double P2z)
        {
            throw new NotImplementedException();
        }

        public object GetActiveSketch2()
        {
            throw new NotImplementedException();
        }

        public Sketch IGetActiveSketch2()
        {
            throw new NotImplementedException();
        }

        public void DrawLightIcons()
        {
            throw new NotImplementedException();
        }

        public object GetLayerManager()
        {
            throw new NotImplementedException();
        }

        public LayerMgr IGetLayerManager()
        {
            throw new NotImplementedException();
        }

        public object CreateCircle2(double XC, double YC, double Zc, double Xp, double Yp, double Zp)
        {
            throw new NotImplementedException();
        }

        public SketchSegment ICreateCircle2(double XC, double YC, double Zc, double Xp, double Yp, double Zp)
        {
            throw new NotImplementedException();
        }

        public object CreateCircleByRadius2(double XC, double YC, double Zc, double Radius)
        {
            throw new NotImplementedException();
        }

        public SketchSegment ICreateCircleByRadius2(double XC, double YC, double Zc, double Radius)
        {
            throw new NotImplementedException();
        }

        public object CreateArc2(double XC, double YC, double Zc, double Xp1, double Yp1, double Zp1, double Xp2, double Yp2,
            double Zp2, short Direction)
        {
            throw new NotImplementedException();
        }

        public SketchSegment ICreateArc2(double XC, double YC, double Zc, double Xp1, double Yp1, double Zp1, double Xp2, double Yp2,
            double Zp2, short Direction)
        {
            throw new NotImplementedException();
        }

        public object CreateEllipse2(double CenterX, double CenterY, double CenterZ, double MajorX, double MajorY, double MajorZ,
            double MinorX, double MinorY, double MinorZ)
        {
            throw new NotImplementedException();
        }

        public SketchSegment ICreateEllipse2(double CenterX, double CenterY, double CenterZ, double MajorX, double MajorY,
            double MajorZ, double MinorX, double MinorY, double MinorZ)
        {
            throw new NotImplementedException();
        }

        public object CreateEllipticalArc2(double CenterX, double CenterY, double CenterZ, double MajorX, double MajorY, double MajorZ,
            double MinorX, double MinorY, double MinorZ, double StartX, double StartY, double StartZ, double EndX, double EndY,
            double EndZ)
        {
            throw new NotImplementedException();
        }

        public SketchSegment ICreateEllipticalArc2(double CenterX, double CenterY, double CenterZ, double MajorX, double MajorY,
            double MajorZ, double MinorX, double MinorY, double MinorZ, double StartX, double StartY, double StartZ,
            double EndX, double EndY, double EndZ)
        {
            throw new NotImplementedException();
        }

        public object CreateSpline(object PointData)
        {
            throw new NotImplementedException();
        }

        public SketchSegment ICreateSpline(int PointCount, ref double PointData)
        {
            throw new NotImplementedException();
        }

        public void ViewZoomtofit2()
        {
            throw new NotImplementedException();
        }

        public void SetInferenceMode(bool InferenceMode)
        {
            throw new NotImplementedException();
        }

        public bool GetInferenceMode()
        {
            throw new NotImplementedException();
        }

        public bool SetTitle2(string NewTitle)
        {
            throw new NotImplementedException();
        }

        public bool SketchFillet2(double Rad, short ConstrainedCorners)
        {
            throw new NotImplementedException();
        }

        public bool IsTessellationValid()
        {
            throw new NotImplementedException();
        }

        public void EditRoute()
        {
            throw new NotImplementedException();
        }

        public void FileReload()
        {
            throw new NotImplementedException();
        }

        public object GetDesignTable()
        {
            throw new NotImplementedException();
        }

        public DesignTable IGetDesignTable()
        {
            throw new NotImplementedException();
        }

        public string GetEntityName(object Entity)
        {
            throw new NotImplementedException();
        }

        public string IGetEntityName(Entity Entity)
        {
            throw new NotImplementedException();
        }

        public ModelDoc2 IGetNext()
        {
            throw new NotImplementedException();
        }

        public bool ShowConfiguration2(string ConfigurationName)
        {
            throw new NotImplementedException();
        }

        public bool AddConfiguration2(string Name, string Comment, string AlternateName, bool SuppressByDefault, bool HideByDefault,
            bool MinFeatureManager, bool InheritProperties, uint Flags)
        {
            throw new NotImplementedException();
        }

        public bool DeleteConfiguration2(string ConfigurationName)
        {
            throw new NotImplementedException();
        }

        public bool EditConfiguration2(string Name, string NewName, string Comment, string AlternateName, bool SuppressByDefault,
            bool HideByDefault, bool MinFeatureManager, bool InheritProperties, uint Flags)
        {
            throw new NotImplementedException();
        }

        public object CreateSplineByEqnParams(object ParamsIn)
        {
            throw new NotImplementedException();
        }

        public SketchSegment ICreateSplineByEqnParams(ref int PropArray, ref double KnotsArray, ref double CntrlPntCoordArray)
        {
            throw new NotImplementedException();
        }

        public object CreateFeatureMgrView2(ref int Bitmap, string ToolTip)
        {
            throw new NotImplementedException();
        }

        public FeatMgrView ICreateFeatureMgrView2(ref int Bitmap, string ToolTip)
        {
            throw new NotImplementedException();
        }

        public bool AddFeatureMgrView2(ref int Bitmap, ref int AppView, string ToolTip)
        {
            throw new NotImplementedException();
        }

        public void FeatureCut3(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2, bool Ddir1,
            bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2, int KeepPieceIndex)
        {
            throw new NotImplementedException();
        }

        public object GetFirstAnnotation2()
        {
            throw new NotImplementedException();
        }

        public Annotation IGetFirstAnnotation2()
        {
            throw new NotImplementedException();
        }

        public void InsertExtendSurface(bool ExtendLinear, int EndCondition, double Distance)
        {
            throw new NotImplementedException();
        }

        public void InsertTangencySurface(bool OneSide, bool IsFlip)
        {
            throw new NotImplementedException();
        }

        public object CreateSplinesByEqnParams(object ParamsIn)
        {
            throw new NotImplementedException();
        }

        public EnumSketchSegments ICreateSplinesByEqnParams(ref int PropArray, ref double KnotsArray, ref double CntrlPntCoordArray)
        {
            throw new NotImplementedException();
        }

        public object CreateClippedSplines(object ParamsIn, double X1, double Y1, double X2, double Y2)
        {
            throw new NotImplementedException();
        }

        public EnumSketchSegments ICreateClippedSplines(ref int PropArray, ref double KnotsArray, ref double CntrlPntCoordArray,
            double X1, double Y1, double X2, double Y2)
        {
            throw new NotImplementedException();
        }

        public bool EditSuppress2()
        {
            throw new NotImplementedException();
        }

        public bool EditUnsuppress2()
        {
            throw new NotImplementedException();
        }

        public bool EditUnsuppressDependent2()
        {
            throw new NotImplementedException();
        }

        public bool EditRollback2()
        {
            throw new NotImplementedException();
        }

        public void HideDimension()
        {
            throw new NotImplementedException();
        }

        public void ShowFeatureDimensions()
        {
            throw new NotImplementedException();
        }

        public void HideFeatureDimensions()
        {
            throw new NotImplementedException();
        }

        public void Sketch3DIntersections()
        {
            throw new NotImplementedException();
        }

        public int FeatureFillet4(double R1, bool Propagate, bool UniformRadius, int Ftyp, bool VarRadTyp, int OverflowType,
            int NRadii, object Radii, bool UseHelpPoint, bool UseTangentHoldLine, bool CornerType, int SetbackDistCount,
            object SetBackDistances)
        {
            throw new NotImplementedException();
        }

        public int IFeatureFillet4(double R1, bool Propagate, bool UniformRadius, int Ftyp, bool VarRadTyp, int OverflowType,
            int NRadii, ref double Radii, bool UseHelpPoint, bool UseTangentHoldLine, bool CornerType, int SetbackDistCount,
            ref double SetBackDistances)
        {
            throw new NotImplementedException();
        }

        public void InsertDeleteFace()
        {
            throw new NotImplementedException();
        }

        public object GetDependencies2(bool Traverseflag, bool Searchflag, bool AddReadOnlyInfo)
        {
            throw new NotImplementedException();
        }

        public string IGetDependencies2(bool Traverseflag, bool Searchflag, bool AddReadOnlyInfo)
        {
            throw new NotImplementedException();
        }

        public int IGetNumDependencies2(bool Traverseflag, bool Searchflag, bool AddReadOnlyInfo)
        {
            throw new NotImplementedException();
        }

        public void InsertScale(double ScaleFactor_x, double ScaleFactor_y, double ScaleFactor_z, bool IsUniform, int ScaleType)
        {
            throw new NotImplementedException();
        }

        public void LockAllExternalReferences()
        {
            throw new NotImplementedException();
        }

        public void UnlockAllExternalReferences()
        {
            throw new NotImplementedException();
        }

        public void BreakAllExternalReferences()
        {
            throw new NotImplementedException();
        }

        public bool EditDimensionProperties(int TolType, double TolMax, double TolMin, string TolMaxFit, string TolMinFit,
            bool UseDocPrec, int Precision, int ArrowsIn, bool UseDocArrows, int Arrow1, int Arrow2)
        {
            throw new NotImplementedException();
        }

        public bool SketchPolygon(double XCenter, double YCenter, double XEdge, double YEdge, int NSides, bool BInscribed)
        {
            throw new NotImplementedException();
        }

        public int GetBlockingState()
        {
            throw new NotImplementedException();
        }

        public object CreateFeatureMgrView3(ref int Bitmap, string ToolTip, int WhichPane)
        {
            throw new NotImplementedException();
        }

        public FeatMgrView ICreateFeatureMgrView3(ref int Bitmap, string ToolTip, int WhichPane)
        {
            throw new NotImplementedException();
        }

        public bool AddFeatureMgrView3(ref int Bitmap, ref int AppView, string ToolTip, int WhichPane)
        {
            throw new NotImplementedException();
        }

        public object CreatePlaneAtOffset2(double Val, bool FlipDir)
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlaneAtOffset2(double Val, bool FlipDir)
        {
            throw new NotImplementedException();
        }

        public object CreatePlaneAtAngle2(double Val, bool FlipDir)
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlaneAtAngle2(double Val, bool FlipDir)
        {
            throw new NotImplementedException();
        }

        public object CreatePlaneThru3Points2()
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlaneThru3Points2()
        {
            throw new NotImplementedException();
        }

        public object CreatePlanePerCurveAndPassPoint2(bool OrigAtCurve)
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlanePerCurveAndPassPoint2(bool OrigAtCurve)
        {
            throw new NotImplementedException();
        }

        public object CreatePlaneAtSurface2(int InterIndex, bool ProjOpt, bool ReverseDir, bool NormalPlane, double Angle)
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlaneAtSurface2(int InterIndex, bool ProjOpt, bool ReverseDir, bool NormalPlane, double Angle)
        {
            throw new NotImplementedException();
        }

        public int GetUserPreferenceIntegerValue(int UserPreferenceValue)
        {
            throw new NotImplementedException();
        }

        public bool SetUserPreferenceIntegerValue(int UserPreferenceValue, int Value)
        {
            throw new NotImplementedException();
        }

        public object GetUserPreferenceTextFormat(int UserPreferenceValue)
        {
            throw new NotImplementedException();
        }

        public TextFormat IGetUserPreferenceTextFormat(int UserPreferenceValue)
        {
            throw new NotImplementedException();
        }

        public bool SetUserPreferenceTextFormat(int UserPreferenceValue, object Value)
        {
            throw new NotImplementedException();
        }

        public bool ISetUserPreferenceTextFormat(int UserPreferenceValue, TextFormat Value)
        {
            throw new NotImplementedException();
        }

        public void InsertRib2(bool Is2Sided, bool ReverseThicknessDir, double Thickness, int ReferenceEdgeIndex,
            bool ReverseMaterialDir, bool IsDrafted, bool DraftOutward, double DraftAngle, bool IsNormToSketch)
        {
            throw new NotImplementedException();
        }

        public bool InsertObjectFromFile(string FilePath, bool CreateLink, double Xx, double Yy, double Zz)
        {
            throw new NotImplementedException();
        }

        public void InspectCurvature()
        {
            throw new NotImplementedException();
        }

        public void RemoveInspectCurvature()
        {
            throw new NotImplementedException();
        }

        public object InsertDatumTag2()
        {
            throw new NotImplementedException();
        }

        public DatumTag IInsertDatumTag2()
        {
            throw new NotImplementedException();
        }

        public int ActivateFeatureMgrView(ref int AppView)
        {
            throw new NotImplementedException();
        }

        public void FeatureSketchDrivenPattern(bool UseCentroid)
        {
            throw new NotImplementedException();
        }

        public void HideShowBodies()
        {
            throw new NotImplementedException();
        }

        public void HideSolidBody()
        {
            throw new NotImplementedException();
        }

        public void ShowSolidBody()
        {
            throw new NotImplementedException();
        }

        public void InsertFramePoint(double Xx, double Yy, double Zz)
        {
            throw new NotImplementedException();
        }

        public void LockFramePoint()
        {
            throw new NotImplementedException();
        }

        public void UnlockFramePoint()
        {
            throw new NotImplementedException();
        }

        public object InsertGtol()
        {
            throw new NotImplementedException();
        }

        public Gtol IInsertGtol()
        {
            throw new NotImplementedException();
        }

        public bool DeActivateFeatureMgrView(ref int AppView)
        {
            throw new NotImplementedException();
        }

        public object InsertNote(string Text)
        {
            throw new NotImplementedException();
        }

        public Note IInsertNote(string Text)
        {
            throw new NotImplementedException();
        }

        public void SetSaveAsFileName(string FileName)
        {
            throw new NotImplementedException();
        }

        public void ClosePrintPreview()
        {
            throw new NotImplementedException();
        }

        public void HideComponent2()
        {
            throw new NotImplementedException();
        }

        public void ShowComponent2()
        {
            throw new NotImplementedException();
        }

        public bool SaveBMP(string FileNameIn, int WidthIn, int HeightIn)
        {
            throw new NotImplementedException();
        }

        public void InsertSketch2(bool UpdateEditRebuild)
        {
            throw new NotImplementedException();
        }

        public void Insert3DSketch2(bool UpdateEditRebuild)
        {
            throw new NotImplementedException();
        }

        public void InsertDeleteHole()
        {
            throw new NotImplementedException();
        }

        public void PreTrimSurface(bool BMutualTrimIn)
        {
            throw new NotImplementedException();
        }

        public void PostTrimSurface(bool BSewSurfaceIn)
        {
            throw new NotImplementedException();
        }

        public void SketchConvertIsoCurves(double PercentRatio, bool VORuDir, bool DoConstrain, bool SkipHoles)
        {
            throw new NotImplementedException();
        }

        public void SelectLoop()
        {
            throw new NotImplementedException();
        }

        public void InsertSheetMetalBaseFlange(double Thickness, bool ThickenDir, double Radius, double ExtrudeDist1,
            double ExtrudeDist2, bool FlipExtruDir, int EndCondition1, int EndCondition2, int DirToUse)
        {
            throw new NotImplementedException();
        }

        public void InsertSheetMetalFold()
        {
            throw new NotImplementedException();
        }

        public void InsertSheetMetalUnfold()
        {
            throw new NotImplementedException();
        }

        public void InsertSheetMetalMiterFlange(bool UseReliefRatio, bool UseDefaultGap, bool UseAutoRelief, double GlobalRadius,
            double RipGap, double AutoReliefRatio, double AutoReliefWidth, double AutoReliefDepth, int ReliefType,
            int RipLocation, bool TrimSideBends)
        {
            throw new NotImplementedException();
        }

        public void CreateGroup()
        {
            throw new NotImplementedException();
        }

        public void RemoveItemsFromGroup()
        {
            throw new NotImplementedException();
        }

        public void RemoveGroups()
        {
            throw new NotImplementedException();
        }

        public object InsertBOMBalloon2(int Style, int Size, int UpperTextStyle, string UpperText, int LowerTextStyle,
            string LowerText)
        {
            throw new NotImplementedException();
        }

        public Note IInsertBOMBalloon2(int Style, int Size, int UpperTextStyle, string UpperText, int LowerTextStyle,
            string LowerText)
        {
            throw new NotImplementedException();
        }

        public void EditRedo(uint NSteps)
        {
            throw new NotImplementedException();
        }

        public void InsertProtrusionBlend4(bool Closed, bool KeepTangency, bool ForceNonRational, double TessToleranceFactor,
            short StartMatchingType, short EndMatchingType, bool IsThinBody, double Thickness1, double Thickness2,
            short ThinType)
        {
            throw new NotImplementedException();
        }

        public void InsertCutBlend4(bool Closed, bool KeepTangency, bool ForceNonRational, double TessToleranceFactor,
            short StartMatchingType, short EndMatchingType, bool IsThinBody, double Thickness1, double Thickness2,
            short ThinType)
        {
            throw new NotImplementedException();
        }

        public void InsertProtrusionSwept4(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency,
            bool ForceNonRational, short StartMatchingType, short EndMatchingType, bool IsThinBody, double Thickness1,
            double Thickness2, short ThinType)
        {
            throw new NotImplementedException();
        }

        public void InsertCutSwept4(bool Propagate, bool Alignment, short TwistCtrlOption, bool KeepTangency, bool ForceNonRational,
            short StartMatchingType, short EndMatchingType, bool IsThinBody, double Thickness1, double Thickness2,
            short ThinType)
        {
            throw new NotImplementedException();
        }

        public void SelectTangency()
        {
            throw new NotImplementedException();
        }

        public bool InsertBendTableOpen(string FileName)
        {
            throw new NotImplementedException();
        }

        public bool InsertBendTableNew(string FileName, string Units, string Type)
        {
            throw new NotImplementedException();
        }

        public void InsertBendTableEdit()
        {
            throw new NotImplementedException();
        }

        public void DeleteBendTable()
        {
            throw new NotImplementedException();
        }

        public void InsertSheetMetal3dBend(double Angle, double Radius, bool FlipDir, short BendPos)
        {
            throw new NotImplementedException();
        }

        public bool CreateTangentArc2(double P1x, double P1y, double P1z, double P2x, double P2y, double P2z, int ArcTypeIn)
        {
            throw new NotImplementedException();
        }

        public object GetMassProperties2(ref int Status)
        {
            throw new NotImplementedException();
        }

        public double IGetMassProperties2(ref int Status)
        {
            throw new NotImplementedException();
        }

        public void SketchChamfer(double AngleORdist, double Dist1, int Options)
        {
            throw new NotImplementedException();
        }

        public void FeatureCut4(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2, bool Ddir1,
            bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2, int KeepPieceIndex,
            bool NormalCut)
        {
            throw new NotImplementedException();
        }

        public PropertyManagerPage GetPropertyManagerPage(int DialogId, string Title, object Handler)
        {
            throw new NotImplementedException();
        }

        public void AlignOrdinate()
        {
            throw new NotImplementedException();
        }

        public void EditOrdinate()
        {
            throw new NotImplementedException();
        }

        public bool ReattachOrdinate()
        {
            throw new NotImplementedException();
        }

        public object EditBalloonProperties(int Style, int Size, int UpperTextStyle, string UpperText, int LowerTextStyle,
            string LowerText)
        {
            throw new NotImplementedException();
        }

        public bool EditDimensionProperties2(int TolType, double TolMax, double TolMin, string TolMaxFit, string TolMinFit,
            bool UseDocPrec, int Precision, int ArrowsIn, bool UseDocArrows, int Arrow1, int Arrow2, string PrefixText,
            string SuffixText, bool ShowValue, string CalloutText1, string CalloutText2, bool CenterText)
        {
            throw new NotImplementedException();
        }

        public void InsertSheetMetalClosedCorner()
        {
            throw new NotImplementedException();
        }

        public bool SketchUseEdge2(bool Chain)
        {
            throw new NotImplementedException();
        }

        public bool SketchOffsetEntities2(double Offset, bool BothDirections, bool Chain)
        {
            throw new NotImplementedException();
        }

        public bool SketchOffset2(double Offset, bool BothDirections, bool Chain)
        {
            throw new NotImplementedException();
        }

        public object AddDimension2(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public DisplayDimension IAddDimension2(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public object AddHorizontalDimension2(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public DisplayDimension IAddHorizontalDimension2(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public object AddVerticalDimension2(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public DisplayDimension IAddVerticalDimension2(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public object AddRadialDimension2(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public DisplayDimension IAddRadialDimension2(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public object AddDiameterDimension2(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public DisplayDimension IAddDiameterDimension2(double X, double Y, double Z)
        {
            throw new NotImplementedException();
        }

        public object GetUserUnit(int UnitType)
        {
            throw new NotImplementedException();
        }

        public UserUnit IGetUserUnit(int UnitType)
        {
            throw new NotImplementedException();
        }

        public object InsertWeldSymbol3()
        {
            throw new NotImplementedException();
        }

        public WeldSymbol IInsertWeldSymbol3()
        {
            throw new NotImplementedException();
        }

        public int SaveAs3(string NewName, int SaveAsVersion, int Options)
        {
            throw new NotImplementedException();
        }

        public string GetUserPreferenceStringValue(int UserPreference)
        {
            throw new NotImplementedException();
        }

        public bool SetUserPreferenceStringValue(int UserPreference, string Value)
        {
            throw new NotImplementedException();
        }

        public void DeleteDesignTable()
        {
            throw new NotImplementedException();
        }

        public bool EditRebuild3()
        {
            throw new NotImplementedException();
        }

        public bool ForceRebuild3(bool TopOnly)
        {
            throw new NotImplementedException();
        }

        public int FeatureFillet5(int Options, double R1, int Ftyp, int OverflowType, object Radii, object SetBackDistances,
            object PointRadiusArray)
        {
            throw new NotImplementedException();
        }

        public int IFeatureFillet5(int Options, double R1, int Ftyp, int OverflowType, int NRadii, ref double Radii,
            int SetbackDistCount, ref double SetBackDistances, int PointCount, ref double PointRadiusArray)
        {
            throw new NotImplementedException();
        }

        public void InsertSheetMetalBreakCorner(int Type, double Distance)
        {
            throw new NotImplementedException();
        }

        public void InsertSheetMetalHem(int Type, int Position, bool Reverse, double DLength, double DGap, double DAngle, double DRad,
            double DMiterGap)
        {
            throw new NotImplementedException();
        }

        public object CreatePlaneAtOffset3(double Val, bool FlipDir, bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlaneAtOffset3(double Val, bool FlipDir, bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public object CreatePlaneAtAngle3(double Val, bool FlipDir, bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlaneAtAngle3(double Val, bool FlipDir, bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public object CreatePlaneThru3Points3(bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlaneThru3Points3(bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public object CreatePlaneThruPtParallelToPlane(bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlaneThruPtParallelToPlane(bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public object CreatePlaneThruLineAndPt(bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlaneThruLineAndPt(bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public object CreatePlanePerCurveAndPassPoint3(bool OrigAtCurve, bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlanePerCurveAndPassPoint3(bool OrigAtCurve, bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public object CreatePlaneAtSurface3(short InterIndex, bool ProjOpt, bool ReverseDir, bool NormalPlane, double Angle,
            bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlaneAtSurface3(short InterIndex, bool ProjOpt, bool ReverseDir, bool NormalPlane, double Angle,
            bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public bool InsertAxis2(bool AutoSize)
        {
            throw new NotImplementedException();
        }

        public bool InsertSketchPicture(string FileName)
        {
            throw new NotImplementedException();
        }

        public void GetZebraStripeData(ref double Size, ref double Ratio, ref int Color1, ref int Color2)
        {
            throw new NotImplementedException();
        }

        public void SetZebraStripeData(double Size, double Ratio, int Color1, int Color2)
        {
            throw new NotImplementedException();
        }

        public void InsertSketchPictureData(short Width, short Height, int PDataIn)
        {
            throw new NotImplementedException();
        }

        public void FeatureCurvePattern(int Num1, double Spacing1, int Num2, double Spacing2, bool FlipDir1, bool FlipDir2,
            bool EqualSpacing1, bool EqualSpacing2, bool UseCentroid, bool AlignToSeed, bool OffsetCurve, bool PatternSeedOnly)
        {
            throw new NotImplementedException();
        }

        public void InsertFeatureReplaceFace()
        {
            throw new NotImplementedException();
        }

        public void InsertRip(double Gap)
        {
            throw new NotImplementedException();
        }

        public object InsertSheetMetalEdgeFlange(object FlangeEdge, object SketchFeat, int BooleanOptions, double DAngle,
            double DRadius, int BendPosition, double DOffsetDist, int ReliefType, double DReliefRatio, double DReliefWidth,
            double DReliefDepth)
        {
            throw new NotImplementedException();
        }

        public Feature IInsertSheetMetalEdgeFlange(Edge FlangeEdge, Feature SketchFeat, int BooleanOptions, double DAngle,
            double DRadius, int BendPosition, double DOffsetDist, int ReliefType, double DReliefRatio, double DReliefWidth,
            double DReliefDepth)
        {
            throw new NotImplementedException();
        }

        public object InsertSketchText(double Ptx, double Pty, double Ptz, string Text, int Alignment, int FlipDirection,
            int HorizontalMirror, int WidthFactor, int SpaceBetweenChars)
        {
            throw new NotImplementedException();
        }

        public SketchText IInsertSketchText(double Ptx, double Pty, double Ptz, string Text, int Alignment, int FlipDirection,
            int HorizontalMirror, int WidthFactor, int SpaceBetweenChars)
        {
            throw new NotImplementedException();
        }

        public void DissolveSketchText()
        {
            throw new NotImplementedException();
        }

        public void MoldDraftAnalysis(double Angle, int Options, object Colors, int Shows)
        {
            throw new NotImplementedException();
        }

        public void InsertSheetMetalJog(double Angle, double Radius, double OffsetDist, bool FlipDir, bool FixProjLen, short DimPos,
            short BendPos)
        {
            throw new NotImplementedException();
        }

        public object InsertSketchForEdgeFlange(object FlangeEdge, double DAngle, bool FlipDir)
        {
            throw new NotImplementedException();
        }

        public Feature IInsertSketchForEdgeFlange(Edge FlangeEdge, double DAngle, bool FlipDir)
        {
            throw new NotImplementedException();
        }

        public void ClearSelection2(bool All)
        {
            throw new NotImplementedException();
        }

        public void ListExternalFileReferences2(out object ModelPathName, out object ComponentPathName, out object Feature,
            out object DataType, out object Status, out object RefEntity, out object FeatCom)
        {
            throw new NotImplementedException();
        }

        public int ListExternalFileReferencesCount2()
        {
            throw new NotImplementedException();
        }

        public void IListExternalFileReferences2(int NumRefs, out string ModelPathName, out string CompPathName, out string Feature,
            out string DataType, out int Status, out string RefEntity, out string FeatComp)
        {
            throw new NotImplementedException();
        }

        public bool InsertDeleteFace2(int Refill)
        {
            throw new NotImplementedException();
        }

        public void AddLoftSection()
        {
            throw new NotImplementedException();
        }

        public object InsertMacroFeature(string CmdFile, string CmdModule, string CmdProcedure, object ParamNames, object ParamTypes,
            object ParamValues, string PmFile, string PmModule, string PmProcedure)
        {
            throw new NotImplementedException();
        }

        public Feature IInsertMacroFeature(string CmdFile, string CmdModule, string CmdProcedure, int ParamCount,
            ref string ParamNames, ref int ParamTypes, ref string ParamValues, string PmFile, string PmModule,
            string PmProcedure)
        {
            throw new NotImplementedException();
        }

        public void ListAuxiliaryExternalFileReferences(out object Feature, out object ExternalFileName)
        {
            throw new NotImplementedException();
        }

        public int ListAuxiliaryExternalFileReferencesCount()
        {
            throw new NotImplementedException();
        }

        public void IListAuxiliaryExternalFileReferences(int NumRefs, out string Feature, out string ExternalFileName)
        {
            throw new NotImplementedException();
        }

        public void FeatureCut5(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2, bool Ddir1,
            bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2, bool TranslateSurface1,
            bool TranslateSurface2, int KeepPieceIndex, bool NormalCut)
        {
            throw new NotImplementedException();
        }

        public void FeatureBoss2(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2)
        {
            throw new NotImplementedException();
        }

        public bool DissolveLibraryFeature()
        {
            throw new NotImplementedException();
        }

        public void FeatureExtruRefSurface2(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2)
        {
            throw new NotImplementedException();
        }

        public void FeatureCutThin2(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, double Thk1, double Thk2, double EndThk, int RevThinDir,
            int CapEnds, bool AddBends, double BendRad)
        {
            throw new NotImplementedException();
        }

        public void FeatureBossThin2(bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2, double Thk1, double Thk2, double EndThk, int RevThinDir,
            int CapEnds, bool AddBends, double BendRad)
        {
            throw new NotImplementedException();
        }

        public void SimpleHole3(double Dia, bool Sd, bool Flip, bool Dir, int T1, int T2, double D1, double D2, bool Dchk1, bool Dchk2,
            bool Ddir1, bool Ddir2, double Dang1, double Dang2, bool OffsetReverse1, bool OffsetReverse2,
            bool TranslateSurface1, bool TranslateSurface2)
        {
            throw new NotImplementedException();
        }

        public void EditUndo2(int Steps)
        {
            throw new NotImplementedException();
        }

        public void EditRedo2(int Steps)
        {
            throw new NotImplementedException();
        }

        public object AddConfiguration3(string Name, string Comment, string AlternateName, int Options)
        {
            throw new NotImplementedException();
        }

        public Configuration IAddConfiguration3(string Name, string Comment, string AlternateName, int Options)
        {
            throw new NotImplementedException();
        }

        public bool EditConfiguration3(string Name, string NewName, string Comment, string AlternateName, int Options)
        {
            throw new NotImplementedException();
        }

        public EquationMgr GetEquationMgr()
        {
            throw new NotImplementedException();
        }

        public double ClosestDistance(object Object1, object Object2, out object Point1, out object Point2)
        {
            throw new NotImplementedException();
        }

        public double IClosestDistance(object Object1, object Object2, out double Point1, out double Point2)
        {
            throw new NotImplementedException();
        }

        public int ReloadOrReplace(bool ReadOnly, string ReplaceFileName, bool DiscardChanges)
        {
            throw new NotImplementedException();
        }

        public string GetCustomInfoValue(string Configuration, string FieldName)
        {
            throw new NotImplementedException();
        }

        public Note InsertStackedBalloon(int Style, int Size, int UpperTextStyle, string UpperText, int LowerTextStyle,
            string LowerText)
        {
            throw new NotImplementedException();
        }

        public bool SaveAs4(string Name, int Version, int Options, ref int Errors, ref int Warnings)
        {
            throw new NotImplementedException();
        }

        public bool Save3(int Options, ref int Errors, ref int Warnings)
        {
            throw new NotImplementedException();
        }

        public object CreatePlaneFixed2(object P1, object P2, object P3, bool UseGlobal)
        {
            throw new NotImplementedException();
        }

        public RefPlane ICreatePlaneFixed2(ref double P1, ref double P2, ref double P3, bool UseGlobal)
        {
            throw new NotImplementedException();
        }

        public int AddOrEditConfiguration(string ConfigName, object Params, object Values)
        {
            throw new NotImplementedException();
        }

        public int IAddOrEditConfiguration(string ConfigName, int ParamCount, ref string ParamNames, ref string ParamValues)
        {
            throw new NotImplementedException();
        }

        public int ForceReleaseLocks()
        {
            throw new NotImplementedException();
        }

        public bool EditDimensionProperties3(int TolType, double TolMax, double TolMin, string TolMaxFit, string TolMinFit,
            bool UseDocPrec, int Precision, int ArrowsIn, bool UseDocArrows, int Arrow1, int Arrow2, string PrefixText,
            string SuffixText, bool ShowValue, string CalloutText1, string CalloutText2, bool CenterText, int ConfigOption,
            object ConfigNames)
        {
            throw new NotImplementedException();
        }

        public bool IEditDimensionProperties3(int TolType, double TolMax, double TolMin, string TolMaxFit, string TolMinFit,
            bool UseDocPrec, int Precision, int ArrowsIn, bool UseDocArrows, int Arrow1, int Arrow2, string PrefixText,
            string SuffixText, bool ShowValue, string CalloutText1, string CalloutText2, bool CenterText, int ConfigOption,
            int Count, ref string ConfigNames)
        {
            throw new NotImplementedException();
        }

        public void InsertSketchPictureDatax64(int Width, int Height, long PDataIn)
        {
            throw new NotImplementedException();
        }

        public object SelectionManager { get; set; }
        public SelectionMgr ISelectionManager { get; }
        public object ActiveView { get; set; }
        public ModelView IActiveView { get; }
        public int LengthUnit { get; set; }
        public string get_LightSourceUserName(int ID)
        {
            throw new NotImplementedException();
        }

        public void set_LightSourceUserName(int ID, string Retval)
        {
            throw new NotImplementedException();
        }

        public object get_LightSourcePropertyValues(int ID)
        {
            throw new NotImplementedException();
        }

        public void set_LightSourcePropertyValues(int ID, object Retval)
        {
            throw new NotImplementedException();
        }

        public string SceneName { get; set; }
        public string SceneUserName { get; set; }
        public double get_ILightSourcePropertyValues(int ID)
        {
            throw new NotImplementedException();
        }

        public void set_ILightSourcePropertyValues(int ID, ref double Retval)
        {
            throw new NotImplementedException();
        }

        public bool Visible { get; set; }
        public string MaterialUserName { get; set; }
        public string MaterialIdName { get; set; }
        public object MaterialPropertyValues { get; set; }
        public double get_IMaterialPropertyValues()
        {
            throw new NotImplementedException();
        }

        public void set_IMaterialPropertyValues(ref double Retval)
        {
            throw new NotImplementedException();
        }

        public short get_PrintSetup(int SetupType)
        {
            throw new NotImplementedException();
        }

        public void set_PrintSetup(int SetupType, short SetupValue)
        {
            throw new NotImplementedException();
        }

        public string SceneBkgImageFileName { get; set; }
        public string get_SummaryInfo(int FieldId)
        {
            throw new NotImplementedException();
        }

        public void set_SummaryInfo(int FieldId, string Retval)
        {
            throw new NotImplementedException();
        }

        public string get_CustomInfo(string FieldName)
        {
            throw new NotImplementedException();
        }

        public void set_CustomInfo(string FieldName, string Retval)
        {
            throw new NotImplementedException();
        }

        public string get_CustomInfo2(string Configuration, string FieldName)
        {
            throw new NotImplementedException();
        }

        public void set_CustomInfo2(string Configuration, string FieldName, string Retval)
        {
            throw new NotImplementedException();
        }

        public bool ShowFeatureErrorDialog { get; set; }
        public double FeatureManagerSplitterPosition { get; set; }
        public string Printer { get; set; }
        public object PageSetup { get; }
        public PageSetup IPageSetup { get; }
        public bool LargeAssemblyMode { get; set; }
        public FeatureManager FeatureManager { get; }
        public ModelViewManager ModelViewManager { get; }
        public ModelDocExtension Extension { get; }
        public ConfigurationManager ConfigurationManager { get; }
        public SketchManager SketchManager { get; }

        #endregion

    }
}
