using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;

namespace SSCC.Views.Utilities.Wait
{
    public sealed partial class ProgressIndicator : DevExpress.XtraWaitForm.WaitForm
    {
        
        /// <summary>
        /// Obtiene o establece si el formulario muestra el porcentaje del progreso.
        /// </summary>
        private Boolean _ShowProgress;

        public Boolean ShowProgress
        {
            set
            {
                if (this._ShowProgress != value)
                {
                    this._ShowProgress = value;

                    this.LoadingCaption();
                }
            }
            get
            {
                return this._ShowProgress;
            }
        }

        private int _Progress;//valor del progreso
        /// <summary>
        /// Obtiene o establece el porcentaje del progreso.
        /// </summary>
        public int Progress
        {
            set
            {
                //Establecer progreso
                this._Progress = value;

                //Actualizar el progreso en pantalla
                this.LoadingCaption();
            }
            get
            {
                //Retornar progreso
                return this._Progress;
            }
        }

        /// <summary>
        /// Actualiza el progreso en pantalla.
        /// </summary>
        private void LoadingCaption()
        {
            if (this._ShowProgress)
            {
                prWaitInfo.Description = "Cargando " + this.Progress + " ...";
            }
            else
            {
                prWaitInfo.Description = "Cargando ...";
            }
        }

        public ProgressIndicator()
        {
            InitializeComponent();
            this.prWaitInfo.AutoHeight = true;

        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.prWaitInfo.Caption = caption;
        }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.prWaitInfo.Description = description;
        }

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {

        }



    }
}