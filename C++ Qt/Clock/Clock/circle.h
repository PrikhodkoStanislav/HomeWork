#pragma once

#include <QtWidgets/QWidget>
#include <QtWidgets/QGraphicsItem>
#include <QtGui/QPainter>

/// Class draw clock dial.
class Circle : public QGraphicsItem
{
public:
    Circle();
    QRectF boundingRect() const override;
    QLineF line0();
    QLineF line5();
    QLineF line10();
    QLineF line15();
    QLineF line20();
    QLineF line25();
    QLineF line30();
    QLineF line35();
    QLineF line40();
    QLineF line45();
    QLineF line50();
    QLineF line55();
    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget) override;
};
