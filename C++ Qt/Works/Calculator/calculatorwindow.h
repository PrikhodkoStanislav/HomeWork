#pragma once

#include <QMainWindow>

namespace Ui {
class CalculatorWindow;
}

/// Class CalculatorWindow show the calculator.
class CalculatorWindow : public QMainWindow
{
    Q_OBJECT

public:
    explicit CalculatorWindow(QWidget *parent = 0);
    ~CalculatorWindow();

private:
    Ui::CalculatorWindow *ui;

private slots:
  void result();
};
