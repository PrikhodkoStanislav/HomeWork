#ifndef PRINTER_H
#define PRINTER_H

#include <QtWidgets>

class Printer : public QGraphicsItem
{
public:
    Printer();
    QRectF boundingRect() const override;
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget) override;
};

#endif // PRINTER_H
