#include <QtWidgets/QSpinBox>

#include "calculatorwindow.h"
#include "ui_calculatorwindow.h"
#include "calculator.h"

CalculatorWindow::CalculatorWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::CalculatorWindow)
{
    ui->setupUi(this);

    connect(ui->value1, SIGNAL(valueChanged(int)), this, SLOT(result()));
    connect(ui->value2, SIGNAL(valueChanged(int)), this, SLOT(result()));
    connect(ui->operation, SIGNAL(currentTextChanged(QString)), this, SLOT(result()));
}

CalculatorWindow::~CalculatorWindow()
{
    delete ui;
}

void CalculatorWindow::result()
{
  int value1 = ui->value1->value();
  int value2 = ui->value2->value();
  char operation = ui->operation->currentText().toStdString()[0];

  Calculator calculator;
  if (calculator.calc(value1, value2, operation) == error)
    ui->lineEdit->setText("Error!");
  else
    ui->lineEdit->setText(QString::number(calculator.calc(value1, value2, operation)));
}
