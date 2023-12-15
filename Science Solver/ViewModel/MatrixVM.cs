using Science_Solver.AppModel;
using Science_Solver.OtherForms;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace Science_Solver.ViewModel
{
    public class MatrixVM : BaseViewModel
    {
        //Matrix A
        private MathematicalMatrix matrixA = new MathematicalMatrix();
        private MathematicalMatrix matrixB = new MathematicalMatrix();
        //Matrix B

        //Row, col
        private string _rowA = "";
        private string _colA = "";
        private string _rowB = "";
        private string _colB = "";

        private string _lamda = "";
        private List<string> _listNumber = new List<string>();

        private string _matrixAValue = "";
        private string _operator = "";
        private string _matrixBValue = "";
        private string _MatrixCValue = "";
        //command
        public ICommand OpenMatrixACommand { get; set; }
        public ICommand OpenMatrixBCommand { get; set; }
        public ICommand lamdaACommand { get; set; }
        public ICommand lamdaBCommand { get; set; }
        public ICommand SetupCommand { get; set; }
        public ICommand CalDetACommand { get; set; }
        public ICommand CalDetBCommand { get; set; }
        public ICommand CalInvACommand { get; set; }
        public ICommand CalInvBCommand { get; set; }
        public ICommand CalRankACommand { get; set; }
        public ICommand CalRankBCommand { get; set; }
        public ICommand CalAdjointACommand { get; set; }
        public ICommand CalAdjointBCommand { get; set; }
        public ICommand CalTransposeACommand { get; set; }
        public ICommand CalTransposeBCommand { get; set; }
        public ICommand CalAminusBCommand { get; set; }
        public ICommand CalBminusACommand { get; set; }
        public ICommand CalAaddBCommand { get; set; }
        public ICommand CalAmultipleBCommand { get; set; }
        public ICommand CalBmultipleACommand { get; set; }
        public ICommand CalAdivideBCommand { get; set; }
        public ICommand CalBdivideACommand { get; set; }
        public MathematicalMatrix MatrixA
        {
            get => matrixA;
            set => matrixA = value;
        }
        public MathematicalMatrix MatrixB
        {
            get => matrixB;
            set => matrixB = value;
        }
        public string RowA
        {
            get => _rowA;
            set
            {
                _rowA = value;
                OnPropertyChanged(nameof(RowA));
            }
        }
        public string ColA
        {
            get => _colA;
            set
            {
                _colA = value;
                OnPropertyChanged(nameof(ColA));
            }
        }
        public string RowB
        {
            get => _rowB;
            set
            {
                _rowB = value;
                OnPropertyChanged(nameof(RowB));
            }
        }
        public string ColB
        {
            get => _colB;
            set
            {
                _colB = value;
                OnPropertyChanged(nameof(ColB));
            }
        }

        public string Lamda
        {
            get => _lamda;
            set
            {
                _lamda = value;
                OnPropertyChanged(nameof(Lamda));
            }
        }

        public List<string> ListNumber
        {
            get => _listNumber;
            set
            {
                _listNumber = value;
                OnPropertyChanged(nameof(ListNumber));
            }
        }
        public string MatrixAValue
        {
            get => _matrixAValue;
            set
            {
                _matrixAValue = value;
                OnPropertyChanged(nameof(MatrixAValue));
            }
        }
        public string Operator
        {
            get => _operator;
            set
            {
                _operator = value;
                OnPropertyChanged(nameof(Operator));
            }
        }
        public string MatrixBValue
        {
            get => _matrixBValue;
            set
            {
                _matrixBValue = value;
                OnPropertyChanged(nameof(MatrixBValue));
            }
        }
        public string MatrixCValue
        {
            get => _MatrixCValue;
            set
            {
                _MatrixCValue = value;
                OnPropertyChanged(nameof(MatrixCValue));
            }
        }



        public MatrixVM()
        {
            SetDefault();

            OpenMatrixACommand = new RelayCommand<Action>(ExecuteOpenMatrixACommand);
            OpenMatrixBCommand = new RelayCommand<Action>(ExecuteOpenMatrixBCommand);

            lamdaACommand = new RelayCommand<Action>(ExecutelamdaACommand);
            lamdaBCommand = new RelayCommand<Action>(ExecutelamdaBCommand);

            SetupCommand = new RelayCommand<Action>(ExecuteSetupCommand);

            CalDetACommand = new RelayCommand<Action>(ExecuteCalDetACommand);
            CalDetBCommand = new RelayCommand<Action>(ExecuteCalDetBCommand);

            CalInvACommand = new RelayCommand<Action>(ExecuteCalInvACommand);
            CalInvBCommand = new RelayCommand<Action>(ExecuteCalInvBCommand);

            CalRankACommand = new RelayCommand<Action>(ExecuteCalRankACommand);
            CalRankBCommand = new RelayCommand<Action>(ExecuteCalRankBCommand);

            CalAdjointACommand = new RelayCommand<Action>(ExecuteCalAdjointACommand);
            CalAdjointBCommand = new RelayCommand<Action>(ExecuteCalAdjointBCommand);

            CalTransposeACommand = new RelayCommand<Action>(ExecuteCalTransposeACommand);
            CalTransposeBCommand = new RelayCommand<Action>(ExecuteCalTransposeBCommand);

            CalAminusBCommand = new RelayCommand<Action>(ExecuteCalAminusBCommand);
            CalBminusACommand = new RelayCommand<Action>(ExecuteCalBminusACommand);

            CalAaddBCommand = new RelayCommand<Action>(ExecuteCalAaddBCommand);

            CalAmultipleBCommand = new RelayCommand<Action>(ExecuteCalAmultipleBCommand);
            CalBmultipleACommand = new RelayCommand<Action>(ExecuteCalBmultipleACommand);

            CalAdivideBCommand = new RelayCommand<Action>(ExecuteCalAdivideBCommand);
            CalBdivideACommand = new RelayCommand<Action>(ExecuteCalBdivideACommand);
        }

        private void ExecuteSetupCommand(Action action)
        {
            MatrixA = new MathematicalMatrix();
            MatrixB = new MathematicalMatrix();
            MatrixAValue = StringFromMatrix(MatrixA);
            MatrixBValue = StringFromMatrix(MatrixB);
        }

        private void ExecuteCalBdivideACommand(Action action)
        {
            try
            {
                if (MathematicalMatrix.Mathematics_MatricSquare(MatrixA.Matrix_Row, MatrixA.Matrix_Colum))
                {
                    if (MathematicalMatrix.MathematicalMatrixBooleanMultiple(MatrixA.Matrix_Colum, MatrixB.Matrix_Row))
                    {
                        MatrixAValue = StringFromMatrix(MatrixA);
                        MatrixBValue = StringFromMatrix(MatrixB);
                        MathematicalMatrix res = MatrixB / MatrixA;
                        MatrixCValue = "B / A  = \n" + StringFromMatrix(res);
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("  Inverse of matrix A can not product to matrix B!!!!");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Matrix A must be square!!!");
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        private void ExecuteCalAdivideBCommand(Action action)
        {
            try
            {
                if (MathematicalMatrix.Mathematics_MatricSquare(MatrixB.Matrix_Row, MatrixB.Matrix_Colum))
                {
                    if (MathematicalMatrix.MathematicalMatrixBooleanMultiple(MatrixB.Matrix_Colum, MatrixA.Matrix_Row))
                    {
                        MatrixAValue = StringFromMatrix(MatrixA);
                        MatrixBValue = StringFromMatrix(MatrixB);
                        MathematicalMatrix res = MatrixA / MatrixB;
                        MatrixCValue = "A / B  = \n" + StringFromMatrix(res);
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("  Inverse of matrix B can not product to matrix A!!!!");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Matrix B must be square!!!");
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        private void ExecuteCalBmultipleACommand(Action action)
        {
            try
            {
                if (MathematicalMatrix.MathematicalMatrixBooleanMultiple(MatrixA.Matrix_Colum, MatrixB.Matrix_Row))
                {
                    MatrixAValue = StringFromMatrix(MatrixA);
                    MatrixBValue = StringFromMatrix(MatrixB);
                    MathematicalMatrix res =  MatrixB * MatrixA;
                    MatrixCValue = "B * A  = \n" + StringFromMatrix(res);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(" B can not Multiple to A !!!!");
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        private void ExecuteCalAmultipleBCommand(Action action)
        {
            try
            {
                if (MathematicalMatrix.MathematicalMatrixBooleanMultiple(MatrixA.Matrix_Colum, MatrixB.Matrix_Row))
                { 
                    MatrixAValue = StringFromMatrix(MatrixA);
                    MatrixBValue = StringFromMatrix(MatrixB);
                    MathematicalMatrix res = MatrixA * MatrixB;
                    MatrixCValue = "A * B  = \n" + StringFromMatrix(res);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(" A can not Multiple to B !!!!");
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        private void ExecuteCalAaddBCommand(Action action)
        {
            try
            {
                if (MatrixA == MatrixB)
                {
                    MatrixAValue = StringFromMatrix(MatrixA);
                    MatrixBValue = StringFromMatrix(MatrixB);
                    MathematicalMatrix res = MatrixA + MatrixB;
                    MatrixCValue = "A + B  = \n" + StringFromMatrix(res);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("matrix A can not add to matrix B!!!");
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        private void ExecuteCalBminusACommand(Action action)
        {
            try
            {
                if (MatrixA == MatrixB)
                {
                    MatrixAValue = StringFromMatrix(MatrixA);
                    MatrixBValue = StringFromMatrix(MatrixB);
                    MathematicalMatrix res = MatrixB - MatrixA;
                    MatrixCValue = "B - A = \n" + StringFromMatrix(res);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(" matrix B can not substract to matrix A!!!");
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        private void ExecuteCalAminusBCommand(Action action)
        {
            try
            {
                if (MatrixA == MatrixB)
                {
                    MatrixAValue = StringFromMatrix(MatrixA);
                    MatrixBValue = StringFromMatrix(MatrixB);
                    MathematicalMatrix res = MatrixA - MatrixB;
                    MatrixCValue = "A - B = \n" + StringFromMatrix(res);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show(" matrix A can not substract to matrix B!!!");
                }
            }
            catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
        }

        private void ExecuteCalTransposeBCommand(Action action)
        {
            try
            {
                MathematicalMatrix res = MathematicalMatrix.MathematicalMatrix_Transpose(MatrixB);
                MatrixBValue = StringFromMatrix(MatrixB);
                MatrixCValue = "Transpose of B :\n" + StringFromMatrix(res);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteCalTransposeACommand(Action action)
        {
            try
            {
                MathematicalMatrix res = MathematicalMatrix.MathematicalMatrix_Transpose(MatrixA);
                MatrixAValue = StringFromMatrix(MatrixA);
                MatrixCValue = "Transpose of A :\n"+ StringFromMatrix(res);
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteCalAdjointBCommand(Action action)
        {
            try
            {
                if (MathematicalMatrix.Mathematics_MatricSquare(MatrixB.Matrix_Row, MatrixB.Matrix_Colum))
                {
                    MathematicalMatrix res = MathematicalMatrix.MathematicalMatrixAdjoint(MatrixB);
                    MatrixBValue = StringFromMatrix(MatrixB);
                    MatrixCValue = "Adjoint of B:\n" + StringFromMatrix(res);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Matrix B must be square !!!");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteCalAdjointACommand(Action action)
        {
            try
            {
                if (MathematicalMatrix.Mathematics_MatricSquare(MatrixA.Matrix_Row, MatrixA.Matrix_Colum))
                {
                    MathematicalMatrix res = MathematicalMatrix.MathematicalMatrixAdjoint(MatrixA);
                    MatrixAValue = StringFromMatrix(MatrixA);
                    MatrixCValue = "Adjoint of A:\n" + StringFromMatrix(res);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Matrix A must be square !!!");
                }
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteCalRankBCommand(Action action)
        {
            MatrixBValue = StringFromMatrix(MatrixB);
            MathematicalMatrix temp = MatrixB;
            MatrixCValue = "Rank(B):" + MathematicalMatrix.Rank(MatrixB.Matrix, MatrixB.Matrix_Row);
            MatrixB = temp;
            MatrixBValue = StringFromMatrix(MatrixB);
        }

        private void ExecuteCalRankACommand(Action action)
        {
            MatrixAValue = StringFromMatrix(MatrixA);
            MathematicalMatrix temp = MatrixA;
            MatrixCValue = "Rank(A):" +MathematicalMatrix.Rank(MatrixA.Matrix,MatrixA.Matrix_Row);
            MatrixA=temp;
            MatrixAValue = StringFromMatrix(MatrixA);
        }

        private void ExecuteCalInvBCommand(Action action)
        {
            try
            {
                if (MathematicalMatrix.Mathematics_MatricSquare(MatrixB.Matrix_Row, MatrixB.Matrix_Colum))
                {
                    MathematicalMatrix res = MathematicalMatrix.MathematicalMatrixInverse(MatrixB);
                    MatrixBValue = StringFromMatrix(MatrixB);
                    MatrixCValue = "Inverse of B:\n" + StringFromMatrix(res);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Matrix B must be square !!!!");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            MatrixBValue = StringFromMatrix(MatrixB);
        }

        private void ExecuteCalInvACommand(Action action)
        {
            try
            {
                if (MathematicalMatrix.Mathematics_MatricSquare(MatrixA.Matrix_Row, MatrixA.Matrix_Colum))
                {
                    MathematicalMatrix res = MathematicalMatrix.MathematicalMatrixInverse(MatrixA);
                    MatrixAValue = StringFromMatrix(MatrixA);
                    MatrixCValue = "Inverse of A:\n" + StringFromMatrix(res);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Matrix A must be square !!!!");
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            MatrixAValue = StringFromMatrix(MatrixA);
        }

        private void ExecuteCalDetBCommand(Action action)
        {
            try
            {
                if (!MathematicalMatrix.Mathematics_MatricSquare(MatrixB.Matrix_Row, MatrixB.Matrix_Colum))
                {
                    System.Windows.Forms.MessageBox.Show("Matrix B has no determinant!");
                }
                else
                {
                    MatrixCValue = "det(B):" + MathematicalMatrix.MathematicalMatrixDeterminant(MatrixB.Matrix, MatrixB.Matrix_Row);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            MatrixBValue = StringFromMatrix(MatrixB);
        }

        private void ExecuteCalDetACommand(Action action)
        {
            try
            {
                if (!MathematicalMatrix.Mathematics_MatricSquare(MatrixA.Matrix_Row, MatrixA.Matrix_Colum))
                {
                    System.Windows.Forms.MessageBox.Show("Matrix A has no determinant!");
                }
                else
                {
                    MatrixCValue = "det(A):" + MathematicalMatrix.MathematicalMatrixDeterminant(MatrixA.Matrix, MatrixA.Matrix_Row);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            MatrixAValue = StringFromMatrix(MatrixA);
        }

        private void ExecutelamdaBCommand(Action action)
        {
            MatrixBValue = StringFromMatrix(MatrixB);
            try
            {
                for (int i = 0; i < MatrixB.Matrix_Row; i++)
                {
                    for (int j = 0; j < MatrixB.Matrix_Colum; j++)
                    {
                        MatrixB.Matrix[i, j] = MatrixB.Matrix[i, j] * double.Parse(Lamda);
                    }
                }
                MatrixCValue = "B=Lamda*B:\n" + StringFromMatrix(MatrixB);
            }
            catch (Exception ex) 
            { 
                System.Windows.Forms.MessageBox.Show(ex.Message); 
            }
            MatrixBValue = StringFromMatrix(MatrixB);
        }

        private void ExecutelamdaACommand(Action action)
        {
            MatrixAValue = StringFromMatrix(MatrixA);
            try
            {
                for (int i = 0; i < MatrixA.Matrix_Row; i++)
                {
                    for (int j = 0; j < MatrixA.Matrix_Colum; j++)
                    {
                        MatrixA.Matrix[i, j] = MatrixA.Matrix[i, j] * double.Parse(Lamda);
                    }
                }
                MatrixCValue = "A=Lamda*A:\n" + StringFromMatrix(MatrixA);
            }
            catch (Exception ex) 
            {
                System.Windows.Forms.MessageBox.Show(ex.Message); 
            }
            MatrixAValue = StringFromMatrix(MatrixA);
        }

        private void ExecuteOpenMatrixBCommand(Action action)
        {
            MatrixB.Matrix_Row = int.Parse(RowB);
            MatrixB.Matrix_Colum = int.Parse(ColB);
            MatrixB.Matrix = new double[matrixB.Matrix_Row, matrixB.Matrix_Colum];

            //if (RowA == "1" && ColA == "1")
            if (MatrixB.Matrix_Row == 1 && MatrixB.Matrix_Colum == 1)
            {
                Matrix1_1 f = new Matrix1_1();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;

            }
            if (MatrixB.Matrix_Row == 1 && MatrixB.Matrix_Colum == 2)
            {
                Matrix1_2 f = new Matrix1_2();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[0, 1] = f.Ma0_1;

            }
            if (MatrixB.Matrix_Row == 1 && MatrixB.Matrix_Colum == 3)
            {
                Matrix1_3 f = new Matrix1_3();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[0, 1] = f.Ma0_1;
                MatrixB.Matrix[0, 2] = f.Ma0_2;
            }
            if (MatrixB.Matrix_Row == 1 && MatrixB.Matrix_Colum == 4)
            {
                Matrix1_4 f = new Matrix1_4();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[0, 1] = f.Ma0_1;
                MatrixB.Matrix[0, 2] = f.Ma0_2;
                MatrixB.Matrix[0, 3] = f.Ma0_3;
            }

            if (MatrixB.Matrix_Row == 2 && MatrixB.Matrix_Colum == 1)
            {
                Matrix2_1 f = new Matrix2_1();
                f.ShowDialog();
                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[1, 0] = f.Ma1_0;

            }
            if (MatrixB.Matrix_Row == 2 && MatrixB.Matrix_Colum == 2)
            {
                Matrix2_2 f = new Matrix2_2();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[0, 1] = f.Ma0_1;

                MatrixB.Matrix[1, 0] = f.Ma1_0;
                MatrixB.Matrix[1, 1] = f.Ma1_1;
            }
            if (MatrixB.Matrix_Row == 2 && MatrixB.Matrix_Colum == 3)
            {
                Matrix2_3 f = new Matrix2_3();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[0, 1] = f.Ma0_1;
                MatrixB.Matrix[0, 2] = f.Ma0_2;


                MatrixB.Matrix[1, 0] = f.Ma1_0;
                MatrixB.Matrix[1, 1] = f.Ma1_1;
                MatrixB.Matrix[1, 2] = f.Ma1_2;
            }
            if (MatrixB.Matrix_Row == 2 && MatrixB.Matrix_Colum == 4)
            {
                Matrix2_4 f = new Matrix2_4();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[0, 1] = f.Ma0_1;
                MatrixB.Matrix[0, 2] = f.Ma0_2;
                MatrixB.Matrix[0, 3] = f.Ma0_3;

                MatrixB.Matrix[1, 0] = f.Ma1_0;
                MatrixB.Matrix[1, 1] = f.Ma1_1;
                MatrixB.Matrix[1, 2] = f.Ma1_2;
                MatrixB.Matrix[1, 3] = f.Ma1_3;
            }

            if (MatrixB.Matrix_Row == 3 && MatrixB.Matrix_Colum == 1)
            {
                Matrix3_1 f = new Matrix3_1();
                f.ShowDialog();
                MatrixB.Matrix[0, 0] = f.Ma0_0;

                MatrixB.Matrix[1, 0] = f.Ma1_0;

                MatrixB.Matrix[2, 0] = f.Ma2_0;

            }
            if (MatrixB.Matrix_Row == 3 && MatrixB.Matrix_Colum == 2)
            {
                Matrix3_2 f = new Matrix3_2();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[0, 1] = f.Ma0_1;

                MatrixB.Matrix[1, 0] = f.Ma1_0;
                MatrixB.Matrix[1, 1] = f.Ma1_1;

                MatrixB.Matrix[2, 0] = f.Ma2_0;
                MatrixB.Matrix[2, 1] = f.Ma2_1;
            }
            if (MatrixB.Matrix_Row == 3 && MatrixB.Matrix_Colum == 3)
            {
                Matrix3_3 f = new Matrix3_3();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[0, 1] = f.Ma0_1;
                MatrixB.Matrix[0, 2] = f.Ma0_2;


                MatrixB.Matrix[1, 0] = f.Ma1_0;
                MatrixB.Matrix[1, 1] = f.Ma1_1;
                MatrixB.Matrix[1, 2] = f.Ma1_2;

                MatrixB.Matrix[2, 0] = f.Ma2_0;
                MatrixB.Matrix[2, 1] = f.Ma2_1;
                MatrixB.Matrix[2, 2] = f.Ma2_2;
            }
            if (MatrixB.Matrix_Row == 3 && MatrixB.Matrix_Colum == 4)
            {
                Matrix3_4 f = new Matrix3_4();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[0, 1] = f.Ma0_1;
                MatrixB.Matrix[0, 2] = f.Ma0_2;
                MatrixB.Matrix[0, 3] = f.Ma0_3;

                MatrixB.Matrix[1, 0] = f.Ma1_0;
                MatrixB.Matrix[1, 1] = f.Ma1_1;
                MatrixB.Matrix[1, 2] = f.Ma1_2;
                MatrixB.Matrix[1, 3] = f.Ma1_3;

                MatrixB.Matrix[2, 0] = f.Ma2_0;
                MatrixB.Matrix[2, 1] = f.Ma2_1;
                MatrixB.Matrix[2, 2] = f.Ma2_2;
                MatrixB.Matrix[2, 3] = f.Ma2_3;
            }

            if (MatrixB.Matrix_Row == 4 && MatrixB.Matrix_Colum == 1)
            {
                Matrix4_1 f = new Matrix4_1();
                f.ShowDialog();
                MatrixB.Matrix[0, 0] = f.Ma0_0;

                MatrixB.Matrix[1, 0] = f.Ma1_0;

                MatrixB.Matrix[2, 0] = f.Ma2_0;

                MatrixB.Matrix[3, 0] = f.Ma3_0;
            }
            if (MatrixB.Matrix_Row == 4 && MatrixB.Matrix_Colum == 2)
            {
                Matrix4_2 f = new Matrix4_2();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[0, 1] = f.Ma0_1;

                MatrixB.Matrix[1, 0] = f.Ma1_0;
                MatrixB.Matrix[1, 1] = f.Ma1_1;

                MatrixB.Matrix[2, 0] = f.Ma2_0;
                MatrixB.Matrix[2, 1] = f.Ma2_1;

                MatrixB.Matrix[3, 0] = f.Ma3_0;
                MatrixB.Matrix[3, 1] = f.Ma3_1;
            }
            if (MatrixB.Matrix_Row == 4 && MatrixB.Matrix_Colum == 3)
            {
                Matrix4_3 f = new Matrix4_3();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[0, 1] = f.Ma0_1;
                MatrixB.Matrix[0, 2] = f.Ma0_2;


                MatrixB.Matrix[1, 0] = f.Ma1_0;
                MatrixB.Matrix[1, 1] = f.Ma1_1;
                MatrixB.Matrix[1, 2] = f.Ma1_2;

                MatrixB.Matrix[2, 0] = f.Ma2_0;
                MatrixB.Matrix[2, 1] = f.Ma2_1;
                MatrixB.Matrix[2, 2] = f.Ma2_2;

                MatrixB.Matrix[3, 0] = f.Ma3_0;
                MatrixB.Matrix[3, 1] = f.Ma3_1;
                MatrixB.Matrix[3, 2] = f.Ma3_2;
            }
            if (MatrixB.Matrix_Row == 4 && MatrixB.Matrix_Colum == 4)
            {
                Matrix4_4 f = new Matrix4_4();
                f.ShowDialog();

                MatrixB.Matrix[0, 0] = f.Ma0_0;
                MatrixB.Matrix[0, 1] = f.Ma0_1;
                MatrixB.Matrix[0, 2] = f.Ma0_2;
                MatrixB.Matrix[0, 3] = f.Ma0_3;

                MatrixB.Matrix[1, 0] = f.Ma1_0;
                MatrixB.Matrix[1, 1] = f.Ma1_1;
                MatrixB.Matrix[1, 2] = f.Ma1_2;
                MatrixB.Matrix[1, 3] = f.Ma1_3;

                MatrixB.Matrix[2, 0] = f.Ma2_0;
                MatrixB.Matrix[2, 1] = f.Ma2_1;
                MatrixB.Matrix[2, 2] = f.Ma2_2;
                MatrixB.Matrix[2, 3] = f.Ma2_3;

                MatrixB.Matrix[3, 0] = f.Ma3_0;
                MatrixB.Matrix[3, 1] = f.Ma3_1;
                MatrixB.Matrix[3, 2] = f.Ma3_2;
                MatrixB.Matrix[3, 3] = f.Ma3_3;
            }
            MatrixBValue = StringFromMatrix(MatrixB);
        }

        private void ExecuteOpenMatrixACommand(Action action)
        {
            MatrixA.Matrix_Row = int.Parse(RowA);
            MatrixA.Matrix_Colum = int.Parse(ColA);
            MatrixA.Matrix = new double[matrixA.Matrix_Row, matrixA.Matrix_Colum];

            //if (RowA == "1" && ColA == "1")
            if (MatrixA.Matrix_Row == 1 && MatrixA.Matrix_Colum == 1)
            {
                Matrix1_1 f = new Matrix1_1();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;

            }
            if (MatrixA.Matrix_Row == 1 && MatrixA.Matrix_Colum == 2)
            {
                Matrix1_2 f = new Matrix1_2();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[0, 1] = f.Ma0_1;

            }
            if (MatrixA.Matrix_Row == 1 && MatrixA.Matrix_Colum == 3)
            {
                Matrix1_3 f = new Matrix1_3();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[0, 1] = f.Ma0_1;
                MatrixA.Matrix[0, 2] = f.Ma0_2;
            }
            if (MatrixA.Matrix_Row == 1 && MatrixA.Matrix_Colum == 4)
            {
                Matrix1_4 f = new Matrix1_4();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[0, 1] = f.Ma0_1;
                MatrixA.Matrix[0, 2] = f.Ma0_2;
                MatrixA.Matrix[0, 3] = f.Ma0_3;
            }

            if (MatrixA.Matrix_Row == 2 && MatrixA.Matrix_Colum == 1)
            {
                Matrix2_1 f = new Matrix2_1();
                f.ShowDialog();
                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[1, 0] = f.Ma1_0;

            }
            if (MatrixA.Matrix_Row == 2 && MatrixA.Matrix_Colum == 2)
            {
                Matrix2_2 f = new Matrix2_2();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[0, 1] = f.Ma0_1;

                MatrixA.Matrix[1, 0] = f.Ma1_0;
                MatrixA.Matrix[1, 1] = f.Ma1_1;
            }
            if (MatrixA.Matrix_Row == 2 && MatrixA.Matrix_Colum == 3)
            {
                Matrix2_3 f = new Matrix2_3();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[0, 1] = f.Ma0_1;
                MatrixA.Matrix[0, 2] = f.Ma0_2;


                MatrixA.Matrix[1, 0] = f.Ma1_0;
                MatrixA.Matrix[1, 1] = f.Ma1_1;
                MatrixA.Matrix[1, 2] = f.Ma1_2;
            }
            if (MatrixA.Matrix_Row == 2 && MatrixA.Matrix_Colum == 4)
            {
                Matrix2_4 f = new Matrix2_4();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[0, 1] = f.Ma0_1;
                MatrixA.Matrix[0, 2] = f.Ma0_2;
                MatrixA.Matrix[0, 3] = f.Ma0_3;

                MatrixA.Matrix[1, 0] = f.Ma1_0;
                MatrixA.Matrix[1, 1] = f.Ma1_1;
                MatrixA.Matrix[1, 2] = f.Ma1_2;
                MatrixA.Matrix[1, 3] = f.Ma1_3;
            }

            if (MatrixA.Matrix_Row == 3 && MatrixA.Matrix_Colum == 1)
            {
                Matrix3_1 f = new Matrix3_1();
                f.ShowDialog();
                MatrixA.Matrix[0, 0] = f.Ma0_0;

                MatrixA.Matrix[1, 0] = f.Ma1_0;

                MatrixA.Matrix[2, 0] = f.Ma2_0;

            }
            if (MatrixA.Matrix_Row == 3 && MatrixA.Matrix_Colum == 2)
            {
                Matrix3_2 f = new Matrix3_2();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[0, 1] = f.Ma0_1;

                MatrixA.Matrix[1, 0] = f.Ma1_0;
                MatrixA.Matrix[1, 1] = f.Ma1_1;

                MatrixA.Matrix[2, 0] = f.Ma2_0;
                MatrixA.Matrix[2, 1] = f.Ma2_1;
            }
            if (MatrixA.Matrix_Row == 3 && MatrixA.Matrix_Colum == 3)
            {
                Matrix3_3 f = new Matrix3_3();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[0, 1] = f.Ma0_1;
                MatrixA.Matrix[0, 2] = f.Ma0_2;


                MatrixA.Matrix[1, 0] = f.Ma1_0;
                MatrixA.Matrix[1, 1] = f.Ma1_1;
                MatrixA.Matrix[1, 2] = f.Ma1_2;

                MatrixA.Matrix[2, 0] = f.Ma2_0;
                MatrixA.Matrix[2, 1] = f.Ma2_1;
                MatrixA.Matrix[2, 2] = f.Ma2_2;
            }
            if (MatrixA.Matrix_Row == 3 && MatrixA.Matrix_Colum == 4)
            {
                Matrix3_4 f = new Matrix3_4();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[0, 1] = f.Ma0_1;
                MatrixA.Matrix[0, 2] = f.Ma0_2;
                MatrixA.Matrix[0, 3] = f.Ma0_3;

                MatrixA.Matrix[1, 0] = f.Ma1_0;
                MatrixA.Matrix[1, 1] = f.Ma1_1;
                MatrixA.Matrix[1, 2] = f.Ma1_2;
                MatrixA.Matrix[1, 3] = f.Ma1_3;

                MatrixA.Matrix[2, 0] = f.Ma2_0;
                MatrixA.Matrix[2, 1] = f.Ma2_1;
                MatrixA.Matrix[2, 2] = f.Ma2_2;
                MatrixA.Matrix[2, 3] = f.Ma2_3;
            }

            if (MatrixA.Matrix_Row == 4 && MatrixA.Matrix_Colum == 1)
            {
                Matrix4_1 f = new Matrix4_1();
                f.ShowDialog();
                MatrixA.Matrix[0, 0] = f.Ma0_0;

                MatrixA.Matrix[1, 0] = f.Ma1_0;

                MatrixA.Matrix[2, 0] = f.Ma2_0;

                MatrixA.Matrix[3, 0] = f.Ma3_0;
            }
            if (MatrixA.Matrix_Row == 4 && MatrixA.Matrix_Colum == 2)
            {
                Matrix4_2 f = new Matrix4_2();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[0, 1] = f.Ma0_1;

                MatrixA.Matrix[1, 0] = f.Ma1_0;
                MatrixA.Matrix[1, 1] = f.Ma1_1;

                MatrixA.Matrix[2, 0] = f.Ma2_0;
                MatrixA.Matrix[2, 1] = f.Ma2_1;

                MatrixA.Matrix[3, 0] = f.Ma3_0;
                MatrixA.Matrix[3, 1] = f.Ma3_1;
            }
            if (MatrixA.Matrix_Row == 4 && MatrixA.Matrix_Colum == 3)
            {
                Matrix4_3 f = new Matrix4_3();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[0, 1] = f.Ma0_1;
                MatrixA.Matrix[0, 2] = f.Ma0_2;


                MatrixA.Matrix[1, 0] = f.Ma1_0;
                MatrixA.Matrix[1, 1] = f.Ma1_1;
                MatrixA.Matrix[1, 2] = f.Ma1_2;

                MatrixA.Matrix[2, 0] = f.Ma2_0;
                MatrixA.Matrix[2, 1] = f.Ma2_1;
                MatrixA.Matrix[2, 2] = f.Ma2_2;

                MatrixA.Matrix[3, 0] = f.Ma3_0;
                MatrixA.Matrix[3, 1] = f.Ma3_1;
                MatrixA.Matrix[3, 2] = f.Ma3_2;
            }
            if (MatrixA.Matrix_Row == 4 && MatrixA.Matrix_Colum == 4)
            {
                Matrix4_4 f = new Matrix4_4();
                f.ShowDialog();

                MatrixA.Matrix[0, 0] = f.Ma0_0;
                MatrixA.Matrix[0, 1] = f.Ma0_1;
                MatrixA.Matrix[0, 2] = f.Ma0_2;
                MatrixA.Matrix[0, 3] = f.Ma0_3;

                MatrixA.Matrix[1, 0] = f.Ma1_0;
                MatrixA.Matrix[1, 1] = f.Ma1_1;
                MatrixA.Matrix[1, 2] = f.Ma1_2;
                MatrixA.Matrix[1, 3] = f.Ma1_3;

                MatrixA.Matrix[2, 0] = f.Ma2_0;
                MatrixA.Matrix[2, 1] = f.Ma2_1;
                MatrixA.Matrix[2, 2] = f.Ma2_2;
                MatrixA.Matrix[2, 3] = f.Ma2_3;

                MatrixA.Matrix[3, 0] = f.Ma3_0;
                MatrixA.Matrix[3, 1] = f.Ma3_1;
                MatrixA.Matrix[3, 2] = f.Ma3_2;
                MatrixA.Matrix[3, 3] = f.Ma3_3;
            }

            MatrixAValue = StringFromMatrix(MatrixA);
        }

        public void SetDefault()
        {
            RowA = "1";
            ColA = "1";
            RowB = "1";
            ColB = "1";
            ListNumber = new List<string> { "1", "2", "3", "4" };
        }
        public string StringFromMatrix(MathematicalMatrix matrix)
        {
            string str = "";
            for (int i = 0; i < matrix.Matrix_Row; i++)
            {
                for (int j = 0; j < matrix.Matrix_Colum; j++)
                    str += "matrix[" + i + "," + j + "]=" + matrix.Matrix[i, j] + " ";
                str += "\n";
            }
            return str;
        }
    }
}
